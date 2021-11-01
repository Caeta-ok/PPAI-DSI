using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class EstrategiaCalculoVisitaCompleta: EstrategiaCalculoDuracionEstimada
    {
        public EstrategiaCalculoVisitaCompleta() { }

        public override int calcularDuracionEstimada(List<Exposicion> listaExposiciones)
        {
            int duracionEstimada = 0;
            foreach (Exposicion expo in listaExposiciones)
            {
                duracionEstimada += expo.calcularDuracionResumida();
            }
            return duracionEstimada;
        }
    }
}
