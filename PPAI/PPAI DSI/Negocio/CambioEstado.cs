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
        private int _id;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        private Estado _estado;
        
        public CambioEstado(CAMBIOSESTADOS cambioEstado)
        {
            _id = cambioEstado.Id_CambioEstado;
            _fechaHoraInicio = cambioEstado.FechaHoraInicio.Value;
            _fechaHoraFin = cambioEstado.FechaHoraFin.Value;
        }

        public CambioEstado() { }

        public void conocerEstado(Estado estado)
        {
            _estado = estado;
        }

        public Estado getEstado()
        {
            return _estado;
        }
        
        public void setFechaHoraInicio(DateTime fechaHoraInicio)
        {
            _fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime getFechaHoraInicio()
        {
            return _fechaHoraInicio;
        }
    }
}
