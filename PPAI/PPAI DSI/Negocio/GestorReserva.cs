using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using PPAI_DSI.Formularios;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public static class GestorReserva
    {
        //private static Sede _sedeSeleccionada;
        private static List<Escuela> _listaEscuelas;
        //private static Reserva _reserva;
        private static List<Sede> _listaSedes;
        private static List<TipoVisita> _listaTiposVisitas;
        private static TipoVisita _tipoVisitaSeleccionada;
        private static Sede _sedeSeleccionada;
        private static List<Exposicion> _listaExposicionesTemporales;
        private static List<Exposicion> _listaExposicionesTemporalesSeleccionadas = new List<Exposicion>();
        private static List<Empleado> _listaGuiasDisponibles = new List<Empleado>();
        private static List<Empleado> _listaGuiasSeleccionados = new List<Empleado>();
        private static Sesion _sesionActual;
        private static Estado _estado;
        private static int _nroReserva;
        private static Escuela _escuelaSeleccionada;
        private static DateTime _fechaReserva;
        private static DateTime _horaReserva;
        private static int _duracionEstimada;
        private static int _cantidadAlumnos;
        private static Empleado _empleadoRegistrador;

        public static void iniciarSesion()
        {
            Usuario usuario = Persistencia.traerUsuarioPorId(1);
            _sesionActual = new Sesion();
            _sesionActual.setFechaHoraInicio(DateTime.Now);
            _sesionActual.setFechaHoraFin(DateTime.Now);
            _sesionActual.conocerUsuario(usuario);
        }

        public static void buscarEscuelas()
        {
            _listaEscuelas = Persistencia.traerEscuelas(); 
        }

        public static void nuevaReserva()
        {
            buscarEscuelas();
        }

        public static List<Escuela> getListaEscuelas()
        {
            return _listaEscuelas;
        }

        public static int validarUsuario(string nombre, string contrasenia)
        {
            Usuario usuario = Persistencia.traerUsuarioPorId(1);
            if (usuario._nombre == nombre)
            {
                if (usuario._contrasenia == contrasenia)
                    return 1;
            }
            return 0;
        }

        public static void tomarSeleccionEscuela(int id)
        {
            foreach(Escuela escuela in _listaEscuelas)
            {
                if(escuela.getId() == id)
                {
                    _escuelaSeleccionada = escuela;
                    break;
                }
            }
        }

        public static void tomarNumeroVisitantes(int numeroVisitantes)
        {
            _cantidadAlumnos = numeroVisitantes;
            buscarSedes(numeroVisitantes);
        }

        private static void buscarSedes(int numeroVisitantes)
        {
            _listaSedes = Persistencia.traerSedesPorCapacidadVisitantes(numeroVisitantes);
        }

        public static List<Sede> getSedes()
        {
            return _listaSedes;
        }

        public static void tomarSeleccionSede(int Id_Sede)
        {
            int aux = Id_Sede;
            foreach(Sede sede in _listaSedes)
            {
                if(sede.getId() == Id_Sede)
                {
                    _sedeSeleccionada = sede;
                }
            }
            buscarTipoVisita();
        }

        private static void buscarTipoVisita()
        {
            _listaTiposVisitas = Persistencia.traerTipoVisita();
        }

        public static List<TipoVisita> getTiposVisitas()
        {
            return _listaTiposVisitas;
        }

        public static void tomarSeleccionTipoVisita(int id)
        {
            _listaExposicionesTemporales = new List<Exposicion>();
            foreach (TipoVisita tipoVisita in _listaTiposVisitas)
            {
                if(tipoVisita.getNombre() == "Por exposicion")
                {
                    _tipoVisitaSeleccionada = tipoVisita;
                    buscarExposicionesTemporales();
                }
            }
        }

        public static void buscarExposicionesTemporales()
        {
            foreach (Exposicion expo in _sedeSeleccionada.getExposiciones()) // Para la sede seleccionada recorrer todas las exposiciones
            {
                if (expo.getTipoExposicion().getNombre() == "Temporal") // Si es temporal
                {
                    if (expo.esVigente()) // Si es vigente
                    {
                        _listaExposicionesTemporales.Add(expo);
                    }
                }
            }
        }

        public static List<Exposicion> getExposicionesTemporales()
        {
            return _listaExposicionesTemporales;
        }

        public static void tomarSeleccionExposicion(List<int> listaIdExposiciones)
        {
            
            _listaExposicionesTemporalesSeleccionadas.Clear();
            foreach(int idExpo in listaIdExposiciones)
            {
                foreach (Exposicion expo in _listaExposicionesTemporales)
                {
                    if(expo.getId() == idExpo)
                    {
                        _listaExposicionesTemporalesSeleccionadas.Add(expo);
                    }
                }
            }
        }

        public static void tomarFechaReserva(DateTime fechaReserva)
        {
            _fechaReserva = fechaReserva;
        }

        public static void tomarHoraReserva(DateTime horaReserva)
        {
            _horaReserva = horaReserva;
            calcularDuracionReserva();
        }

        private static void calcularDuracionReserva()
        {
            _duracionEstimada = _sedeSeleccionada.getDuracionDeExposicion();
        }

        public static int getDuracionEstimada()
        {
            return _duracionEstimada;
        }

        public static bool validarCapacidadVisitantes()
        {
            int cantidadTotal = _cantidadAlumnos + _sedeSeleccionada.sumarCantidadDeVisitantes(_fechaReserva);
            if (cantidadTotal <= _sedeSeleccionada.getCantidadMaixmaVisitantes())
                return true;
            return false;
        }

        public static void buscarGuiasDispFechaReserva() // Los guias tienen que pertenecer a las sedes
        {
            _listaGuiasDisponibles.Clear();
            List<Empleado> listaGuiasSede = _sedeSeleccionada.buscarGuias();
            List<AsignacionVisita> listaAsignacionesVisitas = Persistencia.traerAsignacionesVisita();
            bool flag_disponible = true;
            foreach(Empleado guia in listaGuiasSede)
            {
                if (guia.getHorarioTrabajo().estaDisponibleEnHora(_horaReserva, _duracionEstimada))
                { // Si su horario de trabajo permite abarcar la reserva
                    foreach(AsignacionVisita asign in listaAsignacionesVisitas)
                    {
                        if(asign.estaAsignadoEnFechaVisita(guia, _fechaReserva)) // Si está asignado en esa fecha
                        {
                            if(asign.estaDisponibleEnHora(_horaReserva, _duracionEstimada))
                            { // Si el horario de la reserva se choca con el de la asignación
                                flag_disponible = false;
                                break;
                            }
                        }
                    }
                    if(flag_disponible)
                    {
                        _listaGuiasDisponibles.Add(guia);
                    }
                    else
                    {
                        flag_disponible = true;
                    }
                }
            }
        }

        public static List<Empleado> getGuiasDisponibles()
        {
            return _listaGuiasDisponibles;
        }

        public static void tomarSeleccionGuias(List<int> idGuiasSeleccionados)
        {
            _listaGuiasSeleccionados.Clear();
            foreach(int id in idGuiasSeleccionados)
            {
                _listaGuiasSeleccionados.Add(Persistencia.traerEmpleadoPorId(id));
            }
            buscarEmpleadoLogeado();
            buscarUltimoNroReserva();
            buscarEstadoReserva();
        }

        private static void buscarEmpleadoLogeado()
        {
            _empleadoRegistrador = _sesionActual.getUsuario().getEmpleadoLogeado();
        }

        private static void buscarUltimoNroReserva()
        {
            int nroReserva = Persistencia.traerUltimoNroReserva();
            _nroReserva = nroReserva + 1;
        }

        private static void buscarEstadoReserva()
        {
            _estado = Persistencia.traerEstadoPendienteParaReservas();
        }

        public static void registrarReserva()
        {
            Reserva reserva = new Reserva();
            reserva.setCantidadAlumnos(_cantidadAlumnos);
            reserva.setFechaReserva(_fechaReserva);
            reserva.setHoraReserva(_horaReserva);
            reserva.setFechaHoraCreacion(DateTime.Now);
            reserva.conocerEscuela(_escuelaSeleccionada);
            reserva.setNroReserva(_nroReserva);
            reserva.setSede(_sedeSeleccionada);
            reserva.setDuracionEstimada(_duracionEstimada);
            reserva.conocerEmpleadoRegistrador(_empleadoRegistrador);
            reserva.crearAsignaciones(_listaGuiasSeleccionados);
            foreach(Exposicion expoTemporal in _listaExposicionesTemporalesSeleccionadas)
            {
                reserva.conocerExposicion(expoTemporal);
            }
            CambioEstado cambioEstado = new CambioEstado();
            cambioEstado.setFechaHoraInicio(DateTime.Now);
            cambioEstado.conocerEstado(_estado);
            reserva.conocerCambioEstado(cambioEstado);

            Persistencia.insertarNuevaReserva(reserva);
            Persistencia.insertarSesion(_sesionActual);
        }
    }
}
