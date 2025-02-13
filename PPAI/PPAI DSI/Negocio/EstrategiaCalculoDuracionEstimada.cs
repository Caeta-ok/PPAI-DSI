﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{
    public abstract class EstrategiaCalculoDuracionEstimada
    {
        public abstract int calcularDuracionEstimada(List<Exposicion> listaExposicionesSeleccionadas);
        public abstract List<Exposicion> buscarExposiciones(Sede sede);
    }
}
