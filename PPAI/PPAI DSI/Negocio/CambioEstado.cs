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

        public int Id { get => _id; set => _id = value; }
        public DateTime FechaHoraInicio { get => _fechaHoraInicio; set => _fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => _fechaHoraFin; set => _fechaHoraFin = value; }
        public Estado Estado { get => _estado; set => _estado = value; }
        
        public CambioEstado(CAMBIOSESTADOS cambioEstado)
        {
            _id = cambioEstado.Id_CambioEstado;
            _fechaHoraInicio = cambioEstado.FechaHoraInicio.Value;
            if(cambioEstado.FechaHoraFin != null)
                _fechaHoraFin = cambioEstado.FechaHoraFin.Value;

            // No se incluye el objeto Estado porque el ORM 
            // solo entrega el Id (int) correspondiente
            // a la llave foránea
        }

        public CambioEstado() { }
    }
}
