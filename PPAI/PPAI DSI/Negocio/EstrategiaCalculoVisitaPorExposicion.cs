using System.Collections.Generic;

namespace PPAI_DSI.Negocio
{
    public class EstrategiaCalculoVisitaPorExposicion: EstrategiaCalculoDuracionEstimada
    {
        public EstrategiaCalculoVisitaPorExposicion() { }

        public override int calcularDuracionEstimada(List<Exposicion> listaExposicionesSeleccionadas)
        {
            // Si la visita es POR EXPOSICIÓN se suma la duración extendida de cada obra únicamente de las exposiciones temporales seleccionadas
       
            int duracionEstimada = 0;
            foreach(Exposicion expo in listaExposicionesSeleccionadas)
            {
                duracionEstimada += expo.calcularDuracionExtendida();
            }
            return duracionEstimada;
        }

        public override List<Exposicion> buscarExposiciones(Sede sede)
        {
            // Si la visita es POR EXPOSICIÓN se necesitan las exposiciones temporales
            return sede.getExposicionesTemporales();
        }
    }
}
