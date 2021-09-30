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
        public DetalleExposicion DetalleExposicion { get => _detalleExposicion; set => _detalleExposicion = value; }

        public Exposicion(EXPOSICIONES exposicion) //EXPOSICIONES es un tipo del ORM
        {
            Id = exposicion.Id_Exposicion;
            Nombre = exposicion.Nombre;
            FechaInicio = exposicion.FechaInicio.Value;
            FechaInicioReplanificada = exposicion.FechaInicioReplanificada.Value;
            FechaFin = exposicion.FechaFin.Value;
            FechaFinReplanificada = exposicion.FechaFinReplanificada.Value;
            HoraApertura = DateTime.Parse(exposicion.HoraApertura.Value.ToString());
            HoraCierre = DateTime.Parse(exposicion.HoraCierre.Value.ToString());

            // No se incluye los objetos TipoExposicion, Empleado, PublicoDestino y DetalleExposicion
            // no se incluyen porque el ORM solo entrega el Id (int) correspondiente a la llave foránea
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

        public int calcularDuracionObrasExpuestas()
        {
            return DetalleExposicion.buscarDuracionExtraObra();
        }
    }
}