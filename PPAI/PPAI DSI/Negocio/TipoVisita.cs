using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class TipoVisita
    {
        private int _id;
        private string _nombre;
        public TipoVisita(TIPOSVISITA tipoVisita)
        {
            _id = tipoVisita.Id_TipoVisita;
            _nombre = tipoVisita.Nombre;
        }

        public int getId()
        {
            return _id;
        }

        public string getNombre()
        {
            return _nombre;
        }
    }
}
