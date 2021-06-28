using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class AsignacionVisita
    {
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private DateTime _horaInicio;
        private DateTime _horaFin;
        private Empleado _empleado;
        
        public AsignacionVisita(ASIGNACIONESVISITA asignacionVisita)
        {
            _fechaInicio = asignacionVisita.FechaInicio.Value;
            _fechaFin = asignacionVisita.FechaFin.Value;
            _horaInicio = DateTime.Parse(asignacionVisita.HoraInicio.Value.ToString("HH:mm:ss"));
            _horaFin = DateTime.Parse(asignacionVisita.HoraFin.Value.ToString("HH:mm:ss"));
        }

        public void conocerEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public Empleado getEmpleado()
        {
            return _empleado;
        }

        public bool estaAsignadoEnFechaVisita(Empleado empleado)
        {
            if(empleado.getId() == _empleado.getId())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
