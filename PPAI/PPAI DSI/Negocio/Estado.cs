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
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _ambito;

        public Estado(ESTADOS estado)
        {
            _id = estado.Id_Estado;
            _nombre = estado.Nombre;
            _descripcion = estado.Descripcion;
            _ambito = estado.Ambito;
        }

        public int getId()
        {
            return _id;
        }
    }
}
