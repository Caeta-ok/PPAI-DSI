using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Cargo
    {
        private int _id;
        private string _nombre;
        private string _descripcion;

        public Cargo(CARGOS cargo)
        {
            _id = cargo.Id_Cargo;
            _nombre = cargo.Nombre;
            _descripcion = cargo.Descripcion;
        }
    }
}
