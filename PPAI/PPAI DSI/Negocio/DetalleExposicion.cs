using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class DetalleExposicion
    {
        List<Obra> _listaObras = new List<Obra>();

        public DetalleExposicion(){}

        public void conocerObra(Obra obra)
        {
            _listaObras.Add(obra);
        }

        public List<Obra> getObras()
        {
            return _listaObras;
        }
    }
}
