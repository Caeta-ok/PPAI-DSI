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

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaInicioReplanificada { get => _fechaInicioReplanificada; set => _fechaInicioReplanificada = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public DateTime FechaFinReplanificada { get => _fechaFinReplanificada; set => _fechaFinReplanificada = value; }
        public DateTime HoraApertura { get => _horaApertura; set => _horaApertura = value; }
        public DateTime HoraCierre { get => _horaCierre; set => _horaCierre = value; }
        public TipoExposicion TipoExposicion { get => _tipoExposicion; set => _tipoExposicion = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }
        public PublicoDestino PublicoDestino { get => _publicoDestino; set => _publicoDestino = value; }

        public String PublicoDeDestino
        {
            get { return _publicoDestino.Nombre; }
            set { _publicoDestino.Nombre = value; }
        }

        public DetalleExposicion DetalleExposicion { get => _detalleExposicion; set => _detalleExposicion = value; }

        public Exposicion(EXPOSICIONES exposicion)
        {
            Id = exposicion.Id_Exposicion;
            Nombre = exposicion.Nombre;
            FechaInicio = exposicion.FechaInicio.Value;
            FechaInicioReplanificada = exposicion.FechaInicioReplanificada.Value;
            FechaFin = exposicion.FechaFin.Value;
            FechaFinReplanificada = exposicion.FechaFinReplanificada.Value;
            HoraApertura = DateTime.Parse(exposicion.HoraApertura.Value.ToString());
            HoraCierre = DateTime.Parse(exposicion.HoraCierre.Value.ToString());
        }

        public void conocerTipoExposicion(TipoExposicion tipoExposicion)
        {
            TipoExposicion = tipoExposicion;
        }

        public void conocerEmpelado(Empleado empleado)
        {
            Empleado = empleado;
        }

        public void conocerPublicoDestino(PublicoDestino publicoDestino)
        {
            PublicoDestino = publicoDestino;
        }

        public void conocerDetalleExposicion(DetalleExposicion detalleExposicion)
        {
            DetalleExposicion = detalleExposicion;
        }

        public TipoExposicion getTipoExposicion()
        {
            return TipoExposicion;
        }

        public bool esVigente()
        {
            if (FechaFin > DateTime.Now)
            {
                if (FechaFinReplanificada > DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }

        public int getId()
        {
            return Id;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public DateTime getFechaFin()
        {
            return FechaFin;
        }

        public DateTime getFechaInicio()
        {
            return FechaInicio;
        }

        public DateTime getHoraApertura()
        {
            return HoraApertura;
        }

        public DateTime getHoraCierre()
        {
            return HoraCierre;
        }

        public PublicoDestino getPublicoDestino()
        {
            return PublicoDestino;
        }

        public DetalleExposicion getDetalleExposicion()
        {
            return DetalleExposicion;
        }

        public int calcularDuracionObrasExpuestas()
        {
            return DetalleExposicion.buscarDuracionExtraObra();
        }
    }
}