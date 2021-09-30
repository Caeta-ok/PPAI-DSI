using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Sesion
    {
        private int _id;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraFin;
        private Usuario _usuario;

        public int Id { get => _id; set => _id = value; }
        public DateTime FechaHoraInicio { get => _fechaHoraInicio; set => _fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => _fechaHoraFin; set => _fechaHoraFin = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }

        public Sesion() { }
    }
}
