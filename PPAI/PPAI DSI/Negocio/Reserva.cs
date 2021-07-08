using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Reserva
    {
        private int _id;
        private int _duracionEstimada;
        private DateTime _fechaHoraCreacion;
        private DateTime _fechaReserva;
        private DateTime _horaReserva;
        private DateTime _horaInicioReal;
        private DateTime _horaFinReal;
        private int _cantidadAlumnos;
        private int _cantidadAlumnosConfirmados;
        private Sede _sede;
        private Empleado _empleadoRegistrador;
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();
        private List<AsignacionVisita> _listaAsignacionesVisita = new List<AsignacionVisita>();
        private List<CambioEstado> _listaCambiosEstado = new List<CambioEstado>();
        private Escuela _escuela;
        private int _nroReserva;

        public Reserva(RESERVAS reserva)
        {
            _id = reserva.Id_Reserva;
            _duracionEstimada = reserva.DuracionEstimada.Value;
            _fechaHoraCreacion = reserva.FechaHoraCreacion.Value;
            _fechaReserva = reserva.FechaReserva.Value;
            _horaReserva = DateTime.Parse(reserva.HoraReserva.Value.ToString());
            if(reserva.HoraInicioReal != null)
                _horaInicioReal = DateTime.Parse(reserva.HoraInicioReal.Value.ToString());
            if(reserva.HoraFinReal != null)
                _horaFinReal = DateTime.Parse(reserva.HoraFinReal.Value.ToString());
            _cantidadAlumnos = reserva.CantidadAlumnos.Value;
            if(reserva.CantidadAlumnosConfirmados != null)
                _cantidadAlumnosConfirmados = reserva.CantidadAlumnosConfirmados.Value;
        }

        public Reserva() { }

        public int getId()
        {
            return _id;
        }

        public void conocerAsignacionVisita(AsignacionVisita asignacionVisita)
        {
            _listaAsignacionesVisita.Add(asignacionVisita);
        }

        public List<AsignacionVisita> getAsignacionesVisita()
        {
            return _listaAsignacionesVisita;
        }

        public void conocerCambioEstado(CambioEstado cambioEstado)
        {
            _listaCambiosEstado.Add(cambioEstado);
        }

        public CambioEstado getCambioEstadoActual()
        {
            CambioEstado cambioEstado = _listaCambiosEstado[0];
            foreach(CambioEstado cambioEst in _listaCambiosEstado)
            {
                if(cambioEst.getFechaHoraInicio() > cambioEstado.getFechaHoraInicio())
                {
                    cambioEstado = cambioEst;
                }
            }
            return cambioEstado;
        }

        public void conocerEmpleadoRegistrador(Empleado empleado)
        {
            _empleadoRegistrador = empleado;
        }

        public Empleado getEmpeladoRegistrador()
        {
            return _empleadoRegistrador;
        }

        public void conocerEscuela(Escuela escuela)
        {
            _escuela = escuela;
        }

        public void conocerExposicion(Exposicion exposicion)
        {
            _listaExposiciones.Add(exposicion);
        }

        public List<Exposicion> getExposiciones()
        {
            return _listaExposiciones;
        }

        public void conocerSede(Sede sede)
        {
            _sede = sede;
        }

        public void setCantidadAlumnos(int cantidadAlumnos)
        {
            _cantidadAlumnos = cantidadAlumnos;
        }

        public void setSede(Sede sede)
        {
            _sede = sede;
        }

        public Sede getSede()
        {
            return _sede;
        }

        public void setHoraInicioReal(DateTime horaInicio)
        {
            _horaInicioReal = horaInicio;
        }

        public void setFechaReserva(DateTime fechaReserva)
        {
            _fechaReserva = fechaReserva;
        }

        public void setHoraReserva(DateTime horaReserva)
        {
            _horaReserva = horaReserva;
        }

        public void setDuracionEstimada(int duracion)
        {
            _duracionEstimada = duracion;
        }

        public int getDuracionEstimada()
        {
            return _duracionEstimada;
        }

        public DateTime getFechaReserva()
        {
            return _fechaReserva;
        }

        public int getCantidadAlumnosConfirmados()
        {
            return _cantidadAlumnosConfirmados;
        }

        public int getCantidadAlumnos()
        {
            return _cantidadAlumnos;
        }

        public DateTime getHoraReserva()
        {
            return _horaReserva;
        }

        public void setNroReserva(int nroReserva)
        {
            _nroReserva = nroReserva;
        }

        public int getNroReserva()
        {
            return _nroReserva;
        }

        public void crearAsignaciones(List<Empleado> guiasSeleccionados)
        {
            foreach(Empleado guia in guiasSeleccionados)
            {
                AsignacionVisita asignacionVisita = new AsignacionVisita();
                DateTime horaFinAsignacion = _horaReserva;
                horaFinAsignacion.AddMinutes(double.Parse(_duracionEstimada.ToString()));
                asignacionVisita.setFechaInicio(_fechaReserva);
                asignacionVisita.setFechaFin(_fechaReserva);
                asignacionVisita.setHoraInicio(_horaReserva);
                asignacionVisita.setHoraFin(_horaReserva.AddMinutes(_duracionEstimada));
                asignacionVisita.conocerEmpleado(guia);
                _listaAsignacionesVisita.Add(asignacionVisita);
            }
        }

        public void setFechaHoraCreacion(DateTime fechaHoraCreacion)
        {
            _fechaHoraCreacion = fechaHoraCreacion;
        }

        public DateTime getFechaHoraCreacion()
        {
            return _fechaHoraCreacion;
        }

        public bool esDeFecha(DateTime fecha)
        {
            if (_fechaReserva == fecha)
            {
                return true;
            }
            return false;
        }
    }
}
