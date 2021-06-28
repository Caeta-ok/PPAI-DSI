using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class CambioEstado
    {
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        //private DateTime _horaInicio;
        //private DateTime _horaFin;
        private Estado _estado;
        
        public CambioEstado(CAMBIOSESTADOS cambioEstado)
        {
            _fechaHoraInicio = cambioEstado.FechaHoraInicio.Value;
            _fechaHoraFin = cambioEstado.FechaHoraFin.Value;
        }

        public void conocerEstado(Estado estado)
        {
            _estado = estado;
        }
    }
}
