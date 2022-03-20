using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class EstrategiaCalculoVisitaCompleta: EstrategiaCalculoDuracionEstimada
    {
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();
        public EstrategiaCalculoVisitaCompleta() { }

        public override int calcularDuracionEstimada(List<Exposicion> listaExposicionesSeleccionadas)
        {
            // Si la visita ES COMPLETA se suma la duración resumida de cada obra para calcular la duración estimada de la visita
            // Se utilizan las exposiciones vigentes (no importa si fueron seleccionadas o no)
            int duracionEstimada = 0;
            foreach (Exposicion expo in this._listaExposiciones)
            {
                duracionEstimada += expo.calcularDuracionResumida();
            }
            return duracionEstimada;
        }

        public override List<Exposicion> buscarExposiciones(Sede sede)
        {
            // Si la visita ES COMPLETA se necesitan las exposicoiones vigentes para la sede
            this._listaExposiciones = sede.getExposicionesVigentes();
            return this._listaExposiciones;
        }
    }
}
