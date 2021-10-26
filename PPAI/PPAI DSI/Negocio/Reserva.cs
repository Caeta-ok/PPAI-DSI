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

        public int Id { get => _id; set => _id = value; }
        public int DuracionEstimada { get => _duracionEstimada; set => _duracionEstimada = value; }
        public DateTime FechaHoraCreacion { get => _fechaHoraCreacion; set => _fechaHoraCreacion = value; }
        public DateTime FechaReserva { get => _fechaReserva; set => _fechaReserva = value; }
        public DateTime HoraReserva { get => _horaReserva; set => _horaReserva = value; }
        public DateTime HoraInicioReal { get => _horaInicioReal; set => _horaInicioReal = value; }
        public DateTime HoraFinReal { get => _horaFinReal; set => _horaFinReal = value; }
        public int CantidadAlumnos { get => _cantidadAlumnos; set => _cantidadAlumnos = value; }
        public int CantidadAlumnosConfirmados { get => _cantidadAlumnosConfirmados; set => _cantidadAlumnosConfirmados= value; }
        public Sede Sede { get => _sede; set => _sede = value; }
        public Empleado EmpleadoRegistrador { get => _empleadoRegistrador; set => _empleadoRegistrador = value; }
        public Escuela Escuela { get => _escuela; set => _escuela = value; }
        public int NroReserva { get => _nroReserva; set => _nroReserva = value; }

        public Reserva(RESERVAS reserva) // RESERVAS es un tipo del ORM
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

            // No se incluye los objetos Sede, Empleado y Escuela porque el ORM 
            // solo entrega el Id (int) correspondiente a la llave foránea
        }

        public Reserva() { }

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
                if(cambioEst.FechaHoraInicio > cambioEstado.FechaHoraInicio)
                {
                    cambioEstado = cambioEst;
                }
            }
            return cambioEstado;
        }

        public void conocerExposicion(Exposicion exposicion)
        {
            _listaExposiciones.Add(exposicion);
        }

        public List<Exposicion> getExposiciones()
        {
            return _listaExposiciones;
        }

        public void crearAsignaciones(List<Empleado> guiasSeleccionados)
        {
            foreach(Empleado guia in guiasSeleccionados)
            {
                AsignacionVisita asignacionVisita = new AsignacionVisita();
                DateTime horaFinAsignacion = _horaReserva;
                horaFinAsignacion.AddMinutes(double.Parse(_duracionEstimada.ToString()));

                asignacionVisita.FechaInicio = _fechaReserva;
                asignacionVisita.FechaFin = _fechaReserva;
                asignacionVisita.HoraInicio = _horaReserva;
                asignacionVisita.HoraFin = _horaReserva.AddMinutes(_duracionEstimada);
                asignacionVisita.Empleado = guia;

                _listaAsignacionesVisita.Add(asignacionVisita);
            }
        }

        public bool esDeFecha(DateTime fecha)
        {
            if (_fechaReserva == fecha)
            {
                return true;
            }
            return false;
        }

        //public bool esDeSede(int idSede)
        public bool esDeSede(string nombreSede)
        {
            //if (idSede == this.Id)
            if (nombreSede == this.Sede.Nombre)
                    return true;
            return false;
        }
    }
}
