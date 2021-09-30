using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class DetalleExposicion
    {
        private List<Obra> _listaObras = new List<Obra>();

        public DetalleExposicion(){}

        public void conocerObra(Obra obra)
        {
            _listaObras.Add(obra);
        }

        public List<Obra> getObras()
        {
            return _listaObras;
        }

        public int buscarDuracionExtraObra()
        {
            int duracionDeExposicion = 0;
            foreach (Obra obra in _listaObras)
            {
                duracionDeExposicion += obra.DuracionExtendida;
            }
            return duracionDeExposicion;
        }
    }
}