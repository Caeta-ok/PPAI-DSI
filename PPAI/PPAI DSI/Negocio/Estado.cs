using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Estado
    {
        private string _nombre;
        private string _descripcion;

        public Estado(ESTADOS estado)
        {
            _nombre = estado.Nombre;
            _descripcion = estado.Descripcion;
        }
    }
}
