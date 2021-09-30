using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class HorarioTrabajo
    {
        private DateTime _horaEntrada;
        private DateTime _horaSalida;

        public DateTime HoraEntrada { get => _horaEntrada; set => _horaEntrada = value; }
        public DateTime HoraSalida { get => _horaSalida; set => _horaSalida = value; }

        public HorarioTrabajo(HORARIOSTRABAJOS horarioTrabajo)
        {
            _horaEntrada = DateTime.Parse(horarioTrabajo.HoraEntrada.Value.ToString());
            _horaSalida = DateTime.Parse(horarioTrabajo.HoraSalida.Value.ToString());
        }

        public bool estaDisponibleEnHora(DateTime horaInicio, int duracion)
        {
            // Horas del evento
            int horaInicioEnMinutos = (horaInicio.Hour * 60) + horaInicio.Minute;
            int horaFinEnMinutos = horaInicioEnMinutos + duracion;

            // Horarios del empleado
            int horaEntradaEnMinutos = (_horaEntrada.Hour * 60) + _horaEntrada.Minute;
            int horaSalidaEnMinutos = (_horaSalida.Hour * 60) + _horaSalida.Minute;

            // Si 
                //1) La hora de inicio del evento es despues de la hora de entrada del guia
                    //y
                //2) La hora de fin del evento es antes de la hora de salida del guia
            if(horaInicioEnMinutos >= horaEntradaEnMinutos && horaFinEnMinutos <= horaSalidaEnMinutos)
                return true;
            return false;
        }

        //public DateTime getHoraEntrada()
        //{
        //    return _horaEntrada;
        //}

        //public DateTime getHoraSalida()
        //{
        //    return _horaSalida;
        //}
    }
}
