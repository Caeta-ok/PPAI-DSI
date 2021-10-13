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

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public Cargo(CARGOS cargo)
        {
            Id = cargo.Id_Cargo;
            Nombre = cargo.Nombre;
            Descripcion = cargo.Descripcion;
        }

        public bool esGuia()
        {
            if (this.Id == 13)
                return true;
            return false;
        }
    }
}
