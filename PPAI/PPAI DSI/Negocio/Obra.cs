using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Obra
    {
        private int _duracionExtendida;
        public Obra(OBRAS obra)
        {
            _duracionExtendida = obra.DuracionExtendida.Value;
        }

        public int getDuracionExtendida()
        {
            return _duracionExtendida;
        }
    }
}
