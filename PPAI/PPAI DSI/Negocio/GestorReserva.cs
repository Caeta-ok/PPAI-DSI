using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{

    public class GestorReserva
    {
        private Sede _sedeSeleccionada;

        //GestorReserva()
        //{

        //}
        /*
        public List<Sede> buscarSedes()
        {
        }*/

        public void tomarSeleccionReserva(Sede sede)
        {
            _sedeSeleccionada = sede;
        }
        /*
        public int calcularDuracionReserva()
        {
            // Devuelve la duración en minutos

        }*/
    }

}
