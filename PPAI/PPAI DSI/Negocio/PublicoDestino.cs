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

        public PublicoDestino(PUBLICOSDESTINO publicoDestino)
        {
            _nombre = publicoDestino.Nombre;
            _caracteristicas = publicoDestino.Caracteristicas;
        }

        public string getNombre()
        {
            return _nombre;
        }

    }
}
