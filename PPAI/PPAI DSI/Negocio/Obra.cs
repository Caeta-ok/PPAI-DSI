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
        private int _duracionResumida;

        public int DuracionExtendida { get => _duracionExtendida; set => _duracionExtendida = value; }
        public int DuracionResumida { get => _duracionResumida; set => _duracionResumida = value; }

        public Obra(OBRAS obra)
        {
            DuracionExtendida = obra.DuracionExtendida.Value;
            DuracionResumida = obra.DuracionResumida.Value;
        }
    }
}



