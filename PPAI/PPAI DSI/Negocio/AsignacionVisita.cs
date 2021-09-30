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

        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public DateTime HoraInicio { get => _horaInicio; set => _horaInicio = value; }
        public DateTime HoraFin { get => _horaFin; set => _horaFin = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }

        public AsignacionVisita(ASIGNACIONESVISITA asignacionVisita)
        {
            FechaInicio = asignacionVisita.FechaInicio.Value;
            FechaFin = asignacionVisita.FechaFin.Value;
            HoraInicio = DateTime.Parse(asignacionVisita.HoraInicio.Value.ToString());
            HoraFin = DateTime.Parse(asignacionVisita.HoraFin.Value.ToString());

            // No se incluye el objeto Empleado porque el ORM
            // solo entrega el Id (int) correspondiente a la llave foránea
        }

        public AsignacionVisita() { }

        public bool estaAsignadoEnFechaVisita(Empleado empleado, DateTime fechaReserva)
        {

            if (empleado.Id == _empleado.Id)
            {
                if (_fechaInicio == fechaReserva)
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
    }
}
