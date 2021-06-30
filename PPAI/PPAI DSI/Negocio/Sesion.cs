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

        public Sesion() { }

        public void conocerUsuario(Usuario usuario)
        {
            _usuario = usuario;
        }

        public void setFechaHoraInicio(DateTime fechaHoraInicio)
        {
            _fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime getFechaHoraInicio()
        {
            return _fechaHoraInicio;
        }

        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            _fechaHoraFin = fechaHoraFin;
        }

        public DateTime getFechaHoraFin()
        {
            return _fechaHoraFin;
        }

        public Usuario getUsuario()
        {
            return _usuario;
        }
    }
}
