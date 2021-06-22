using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class Sede
    {
        private List<Exposicion> _exposiciones;
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public void conocerExposicion(Exposicion exposicion)
        {
            _exposiciones.Add(exposicion);
        }

        public Sede getSede()
        {
            Sede sede = new Sede();
            sede.nombre = this.nombre;
            foreach(Exposicion e in _exposiciones)
            {
                sede.conocerExposicion(e);
            }
            return sede;
        }

        /*
        public int calcularDuracionEstimada()
        {

        }*/
    }
}
