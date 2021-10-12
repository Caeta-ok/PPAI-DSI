using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class PublicoDestino
    {
        private string _caracteristicas;
        private string _nombre;

        public string Caracteristicas { get => _caracteristicas; set => _caracteristicas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public PublicoDestino(PUBLICOSDESTINO publicoDestino)
        {
            Nombre = publicoDestino.Nombre;
            Caracteristicas = publicoDestino.Caracteristicas;
        }
    }
}