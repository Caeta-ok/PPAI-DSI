using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class AsignacionVisita
    {
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private DateTime _horaInicio;
        private DateTime _horaFin;
        private Empleado _empleado;
        
        public AsignacionVisita(ASIGNACIONESVISITA asignacionVisita)
        {
            _fechaInicio = asignacionVisita.FechaInicio.Value;
            _fechaFin = asignacionVisita.FechaFin.Value;
            _horaInicio = DateTime.Parse(asignacionVisita.HoraInicio.Value.ToString());
            _horaFin = DateTime.Parse(asignacionVisita.HoraFin.Value.ToString());
        }

        public AsignacionVisita() { }

        public void conocerEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public Empleado getEmpleado()
        {
            return _empleado;
        }

        public bool estaAsignadoEnFechaVisita(Empleado empleado, DateTime fechaReserva)
        {
            if(empleado.getId() == _empleado.getId())
            {
                if(_fechaInicio == fechaReserva)
                {
                    return true;
                }
            }
            return false;
        }

        public bool estaDisponibleEnHora(DateTime horaInicioReserva, int duracion)
        {
            // Horas del evento
            int horaInicioReservaEnMinutos = (horaInicioReserva.Hour * 60) + horaInicioReserva.Minute;
            int horaFinReservaEnMinutos = horaInicioReservaEnMinutos + duracion;

            // Horas de la asignación
            int horaInicioAsignEnMinutos = (_horaInicio.Hour * 60) + _horaInicio.Minute;
            int horaFinAsignEnMinutos = (_horaFin.Hour * 60) + _horaFin.Minute;

            // Si 
            //1) La hora de fin de reserva es antes de la hora de inicio de la asignación
                // ó
            //2) La hora de incio de la reserva es despues de la hora de finalización de la asignación
            if (horaFinReservaEnMinutos < horaInicioAsignEnMinutos || horaInicioReservaEnMinutos > horaFinAsignEnMinutos)
                return true;
            return false;
        }

        public void setFechaInicio(DateTime fechaInicio)
        {
            _fechaInicio = fechaInicio;
        }

        public DateTime getFechaInicio()
        {
            return _fechaInicio;
        }

        public void setFechaFin(DateTime fechaFin)
        {
            _fechaFin = fechaFin;
        }

        public DateTime getFechaFin()
        {
            return _fechaFin;
        }

        public void setHoraInicio(DateTime horaInicio)
        {
            _horaInicio = horaInicio;
        }

        public DateTime getHoraInicio()
        {
            return _horaInicio;
        }

        public void setHoraFin(DateTime horaFin)
        {
            _horaFin = horaFin;
        }

        public DateTime getHoraFin()
        {
            return _horaFin;
        }
    }
}
