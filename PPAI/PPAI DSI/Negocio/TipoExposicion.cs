using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class TipoExposicion
    {
        private string _nombre;
        private string _descripcion;

        public TipoExposicion(TIPOSEXPOSICION tipoExposicion)
        {
            _nombre = tipoExposicion.Nombre;
            _descripcion = tipoExposicion.Descripcion;
        }

        public string getNombre()
        {
            return _nombre;
        }


        /*
        public bool esExposicionTemporal()
        {

        }*/
    }
}
