using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class DetalleExposicion
    {
        //private List<Obra> _listaObras = new List<Obra>();
        private Obra _obra;
        private string _lugarAsignado;

        public Obra Obra { get => _obra; set => _obra = value; }
        public string LugarAsignado { get => _lugarAsignado; set => _lugarAsignado = value; }

        public DetalleExposicion(DETALLESEXPOSICION detalleExposicion) // DETALLESEXPOSICION es un tipo del ORM
        {
            this.LugarAsignado = detalleExposicion.LugarAsignado;
            //No se incluye Obra porque el ORM solo deveulve el valor de la clave foránea (int)
        }
    }
}