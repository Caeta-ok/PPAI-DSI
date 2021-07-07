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
    public class GestorReserva
    {
        //private static Sede _sedeSeleccionada;
        private List<Escuela> _listaEscuelas;

        //private static Reserva _reserva;
        private List<Sede> _listaSedes;

        private List<TipoVisita> _listaTiposVisitas;
        private TipoVisita _tipoVisitaSeleccionada;
        private Sede _sedeSeleccionada;
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();
        private List<Exposicion> _listaExposicionesVigentes = new List<Exposicion>();
        private List<Exposicion> _listaExposicionesTemporalesVigentes = new List<Exposicion>();
        private List<Exposicion> _listaExposicionesTemporalesSeleccionadas = new List<Exposicion>();
        private List<Empleado> _listaGuiasDisponibles = new List<Empleado>();
        private List<Empleado> _listaGuiasSeleccionados = new List<Empleado>();
        private Sesion _sesionActual;
        private Estado _estado;
        private int _nroReserva;
        private double _guiasNecesarios;
        private Escuela _escuelaSeleccionada;
        private DateTime _fechaReserva;
        private DateTime _horaReserva;
        private int _duracionEstimada;
        private int _cantidadAlumnos;
        private Empleado _empleadoRegistrador;

        public void iniciarSesion()
        {
            Usuario usuario = Persistencia.traerUsuarioPorId(1);
            _sesionActual = new Sesion();
            _sesionActual.setFechaHoraInicio(DateTime.Now);
            _sesionActual.setFechaHoraFin(DateTime.Now);
            _sesionActual.conocerUsuario(usuario);
        }

        public void nuevaReserva()
        {
            buscarEscuelas();
        }

        public List<Escuela> buscarEscuelas()
        {
            return _listaEscuelas = Persistencia.traerEscuelas();
        }

        public int validarUsuario(string nombre, string contrasenia)
        {
            Usuario usuario = Persistencia.traerUsuarioPorId(1);
            if (usuario._nombre == nombre)
            {
                if (usuario._contrasenia == contrasenia)
                    return 1;
            }
            return 0;
        }

        public void tomarSeleccionEscuela(Escuela escuela)
        {
            _escuelaSeleccionada = escuela;
        }

        public void tomarNumeroVisitantes(int numeroVisitantes)
        {
            _cantidadAlumnos = numeroVisitantes;
        }

        public List<Sede> buscarSedes()
        {
            return _listaSedes = Persistencia.traerSedes();
        }

        public void tomarSeleccionSede(Sede sede_seleccionada)
        {
            _sedeSeleccionada = sede_seleccionada;
        }

        public List<TipoVisita> buscarTipoVisita()
        {
            return _listaTiposVisitas = Persistencia.traerTipoVisita();
        }

        //public void tomarSeleccionTipoVisita(TipoVisita tipo_visita_seleccionada)
        //{
        //    _tipoVisitaSeleccionada = tipo_visita_seleccionada;
        //}
        public void tomarSeleccionPorExposicion(TipoVisita tipo_visita_seleccionada)
        {
            _tipoVisitaSeleccionada = tipo_visita_seleccionada;
        }

        public bool esTipoVisitaPorExposicion(TipoVisita tipoVisitaSeleccionada)
        {
            if (tipoVisitaSeleccionada.getNombre() == "Por exposicion")
                return true;
            else
                return false;
        }

        public List<Exposicion> buscarExposicionesTemporales()
        {
            _listaExposiciones.Clear();
            _listaExposicionesVigentes.Clear();
            _listaExposicionesTemporalesVigentes.Clear();
            _listaExposiciones = Persistencia.traerExposiciones(_sedeSeleccionada);
            foreach (Exposicion expo_vigente in _listaExposiciones)
            {
                if (expo_vigente.esVigente())
                {
                    _listaExposicionesVigentes.Add(expo_vigente);
                }
            }
            foreach (Exposicion expo_temporal in _listaExposicionesVigentes)
            {
                //Obtengo del objeto Exposicion el objeto TipoExposicion y le pregunto si es Temporal si es asi relleno la lista
                if (expo_temporal.getTipoExposicion().esExposicionTemporal())
                    _listaExposicionesTemporalesVigentes.Add(expo_temporal);
            }
            return _listaExposicionesTemporalesVigentes;
        }

        public void tomarSeleccionExposicion(List<Exposicion> listaExposiciones)
        {
            _listaExposicionesTemporalesSeleccionadas = listaExposiciones;
        }

        public void tomarFechaReserva(DateTime fechaReserva)
        {
            _fechaReserva = fechaReserva;
        }

        public void tomarHoraReserva(DateTime horaReserva)
        {
            _horaReserva = horaReserva;
            calcularDuracionReserva();
        }

        private void calcularDuracionReserva()
        {
            _duracionEstimada = _sedeSeleccionada.getDuracionDeExposicion(_listaExposicionesTemporalesSeleccionadas);
        }

        public int getDuracionEstimada()
        {
            return _duracionEstimada;
        }

        private void calcularGuiasNecesarios()
        {
            _guiasNecesarios = Math.Round(Convert.ToDouble(_cantidadAlumnos / _sedeSeleccionada.getCantidadMaximaPorGuia()));
        }

        public double getGuiasNecesarios()
        {
            return _guiasNecesarios;
        }

        public bool validarCapacidadVisitantes()
        {
            int cantidadTotal = _cantidadAlumnos + _sedeSeleccionada.sumarCantidadDeVisitantes(_fechaReserva);
            if (cantidadTotal <= _sedeSeleccionada.getCantidadMaixmaVisitantes())
                return true;
            return false;
        }

        public void buscarGuiasDispFechaReserva() // Los guias tienen que pertenecer a las sedes
        {
            calcularGuiasNecesarios();
            _listaGuiasDisponibles.Clear();
            List<Empleado> listaGuiasSede = _sedeSeleccionada.buscarGuias();
            List<AsignacionVisita> listaAsignacionesVisitas = Persistencia.traerAsignacionesVisita();
            bool flag_disponible = true;
            foreach (Empleado guia in listaGuiasSede)
            {
                if (guia.getHorarioTrabajo().estaDisponibleEnHora(_horaReserva, _duracionEstimada))
                { // Si su horario de trabajo permite abarcar la reserva
                    foreach (AsignacionVisita asign in listaAsignacionesVisitas)
                    {
                        if (asign.estaAsignadoEnFechaVisita(guia, _fechaReserva)) // Si está asignado en esa fecha
                        {
                            if (asign.estaDisponibleEnHora(_horaReserva, _duracionEstimada))
                            { // Si el horario de la reserva se choca con el de la asignación
                                flag_disponible = false;
                                break;
                            }
                        }
                    }
                    if (flag_disponible)
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

        public List<Empleado> getGuiasDisponibles()
        {
            return _listaGuiasDisponibles;
        }

        public void tomarSeleccionGuias(List<int> idGuiasSeleccionados)
        {
            _listaGuiasSeleccionados.Clear();
            foreach (int id in idGuiasSeleccionados)
            {
                _listaGuiasSeleccionados.Add(Persistencia.traerEmpleadoPorId(id));
            }
            buscarEmpleadoLogeado();
            buscarUltimoNroReserva();
            buscarEstadoReserva();
        }

        private void buscarEmpleadoLogeado()
        {
            _empleadoRegistrador = _sesionActual.getUsuario().getEmpleadoLogeado();
        }

        private void buscarUltimoNroReserva()
        {
            int nroReserva = Persistencia.traerUltimoNroReserva();
            _nroReserva = nroReserva + 1;
        }

        private void buscarEstadoReserva()
        {
            _estado = Persistencia.traerEstadoPendienteParaReservas();
        }

        public void registrarReserva()
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
            foreach (Exposicion expoTemporal in _listaExposicionesTemporalesSeleccionadas)
            {
                reserva.conocerExposicion(expoTemporal);
            }
            CambioEstado cambioEstado = new CambioEstado();
            cambioEstado.setFechaHoraInicio(DateTime.Now);
            cambioEstado.conocerEstado(_estado);
            reserva.conocerCambioEstado(cambioEstado);

            //Persistencia.insertarNuevaReserva(reserva);
            Persistencia.insertarReserva(reserva);
            Persistencia.insertarSesion(_sesionActual);
        }
    }
}