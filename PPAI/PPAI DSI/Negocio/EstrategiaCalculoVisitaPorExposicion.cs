using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public class EstrategiaCalculoVisitaPorExposicion: EstrategiaCalculoDuracionEstimada
    {
        public EstrategiaCalculoVisitaPorExposicion() { }

        public override int calcularDuracionEstimada(List<Exposicion> listaExposiciones)
        {
            int duracionEstimada = 0;
            foreach(Exposicion expo in listaExposiciones)
            {
                duracionEstimada += expo.calcularDuracionExtendida();
            }
            return duracionEstimada;
        }
    }
}
