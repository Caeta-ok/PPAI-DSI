using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class GestorReserva
    {
        private List<Escuela> _listaEscuelas;
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
        private EstrategiaCalculoDuracionEstimada _estrategiaCalculoDuracionEstimada;

        public void iniciarSesion()
        {
            Usuario usuario = Persistencia.traerUsuarioPorId(1);
            _sesionActual = new Sesion();
            _sesionActual.FechaHoraInicio = DateTime.Now;
            _sesionActual.FechaHoraFin = DateTime.Now;
            _sesionActual.Usuario = usuario;
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

        public void tomarSeleccionTipoVisita(TipoVisita tipoVisitaSeleccionada)
        {
            this._tipoVisitaSeleccionada = tipoVisitaSeleccionada;
            this.crearEstrategiaCalculoDuracionEstimada();
        }

        private void crearEstrategiaCalculoDuracionEstimada()
        {
            if (this._tipoVisitaSeleccionada.esPorExposicion())
            {
                //_tipoVisitaSeleccionada = tipoVisitaSeleccionada;
                this._estrategiaCalculoDuracionEstimada = new EstrategiaCalculoVisitaPorExposicion();
            }
            else
            {
                this._estrategiaCalculoDuracionEstimada = new EstrategiaCalculoVisitaCompleta();
            }
        }

        public List<Exposicion> buscarExposicionesTemporales()
        {
            _listaExposiciones.Clear();
            _listaExposicionesTemporalesVigentes.Clear();
            _listaExposiciones = Persistencia.traerExposiciones(_sedeSeleccionada);
            foreach (Exposicion exposicion in _listaExposiciones) // Loop Mientras haya exposiciones
            {
                if (exposicion.esVigente())
                {
                    if (exposicion.TipoExposicion.esExposicionTemporal())
                    {
                        _listaExposicionesTemporalesVigentes.Add(exposicion);
                    }
                }
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
            //_duracionEstimada = _sedeSeleccionada.getDuracionDeExposicion(_listaExposicionesTemporalesSeleccionadas);
            this._duracionEstimada = this._estrategiaCalculoDuracionEstimada.calcularDuracionEstimada(this._listaExposicionesTemporalesSeleccionadas);
        }

        public int getDuracionEstimada()
        {
            return _duracionEstimada;
        }

        private void calcularGuiasNecesarios()
        {
            _guiasNecesarios = _sedeSeleccionada.getCantidadGuiasNecesarios(_cantidadAlumnos);
        }

        public double getGuiasNecesarios()
        {
            return _guiasNecesarios;
        }

        public bool validarCapacidadVisitantes()
        {
            return _sedeSeleccionada.validarCapacidadVisitantes(_fechaReserva, _cantidadAlumnos);
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
                if (guia.HorarioTrabajo.estaDisponibleEnHora(_horaReserva, _duracionEstimada))
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
            _empleadoRegistrador = _sesionActual.Usuario.getEmpleadoLogeado();
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
            reserva.CantidadAlumnos = _cantidadAlumnos;
            reserva.FechaReserva = _fechaReserva;
            reserva.HoraReserva = _horaReserva;
            reserva.FechaHoraCreacion = DateTime.Now;
            reserva.Escuela = _escuelaSeleccionada;
            reserva.NroReserva = _nroReserva;
            reserva.Sede = _sedeSeleccionada;
            reserva.DuracionEstimada = _duracionEstimada;
            reserva.EmpleadoRegistrador = _empleadoRegistrador;

            reserva.crearAsignaciones(_listaGuiasSeleccionados);
            foreach (Exposicion expoTemporal in _listaExposicionesTemporalesSeleccionadas)
            {
                reserva.conocerExposicion(expoTemporal);
            }
            CambioEstado cambioEstado = new CambioEstado();
            cambioEstado.FechaHoraInicio = DateTime.Now;
            cambioEstado.Estado = _estado;
            reserva.conocerCambioEstado(cambioEstado);

            Persistencia.insertarReserva(reserva);
            Persistencia.insertarSesion(_sesionActual);
        }
    }
}