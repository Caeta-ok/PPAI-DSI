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
        public HorarioTrabajo(HORARIOSTRABAJOS horarioTrabajo)
        {
            _horaEntrada = DateTime.Parse(horarioTrabajo.HoraEntrada.Value.ToString("HH:mm:ss"));
            _horaSalida = DateTime.Parse(horarioTrabajo.HoraSalida.Value.ToString("HH:mm:ss"));
        }
    }
}
