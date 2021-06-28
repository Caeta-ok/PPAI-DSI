using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Exposicion
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaInicioReplanificada;
        private DateTime _fechaFin;
        private DateTime _fechaFinReplanificada;
        private DateTime _horaApertura;
        private DateTime _horaCierre;
        private TipoExposicion _tipoExposicion;
        private Empleado _empleado;
        private PublicoDestino _publicoDestino;
        private DetalleExposicion _detalleExposicion;

        public Exposicion(EXPOSICIONES exposicion)
        {
            _id = exposicion.Id_Exposicion;
            _nombre = exposicion.Nombre;
            _fechaInicio = exposicion.FechaInicio.Value;
            _fechaInicioReplanificada = exposicion.FechaInicioReplanificada.Value;
            _fechaFin = exposicion.FechaFin.Value;
            _fechaFinReplanificada = exposicion.FechaFinReplanificada.Value;
            _horaApertura = DateTime.Parse(exposicion.HoraApertura.Value.ToString());
            _horaCierre = DateTime.Parse(exposicion.HoraCierre.Value.ToString());
        }

        public void conocerTipoExposicion(TipoExposicion tipoExposicion)
        {
            _tipoExposicion = tipoExposicion;
        }

        public void conocerEmpelado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public void conocerPublicoDestino(PublicoDestino publicoDestino)
        {
            _publicoDestino = publicoDestino;
        }
        
        public void conocerDetalleExposicion(DetalleExposicion detalleExposicion)
        {
            _detalleExposicion = detalleExposicion;
        }

        public TipoExposicion getTipoExposicion()
        {
            return _tipoExposicion;
        }

        public bool esVigente()
        {
            if(_fechaFin > DateTime.Now)
            {
                if(_fechaFinReplanificada > DateTime.Now)
                {
                    return true; 
                }
            }
            return false;
        }

        public int getId()
        {
            return _id;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public DateTime getFechaFin()
        {
            return _fechaFin;
        }

        public DateTime getFechaInicio()
        {
            return _fechaInicio;
        }

        public DateTime getHoraApertura()
        {
            return _horaApertura;
        }

        public DateTime getHoraCierre()
        {
            return _horaCierre;
        }

        public PublicoDestino getPublicoDestino()
        {
            return _publicoDestino;
        }

        public DetalleExposicion getDetalleExposicion()
        {
            return _detalleExposicion;
        }


        /*
        public int calcularDuracionObrasExpuestas()
        {

        }*/

        /*
        public bool esVigente()
        {

        }*/

    }
}
