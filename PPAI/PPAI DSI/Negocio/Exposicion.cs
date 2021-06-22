using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Negocio
{

    public class Exposicion
    {
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaInicioReplanificada;
        private DateTime _fechaFin;
        private DateTime _fechaFinReplanificada;
        private DateTime _horaApertura;
        private DateTime _horaCierre;

        public string nombre
        {
            get{return _nombre;}
            set{_nombre = value;}
        }

        public DateTime fechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime fechaInicioReplanificada
        {
            get { return _fechaInicioReplanificada; }
            set { _fechaInicioReplanificada = value; }
        }

        public DateTime fechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        public DateTime fechaFinReplanificada
        {
            get { return _fechaFinReplanificada; }
            set { _fechaFinReplanificada = value; }
        }

        public DateTime horaApertura
        {
            get { return _horaApertura; }
            set { _horaApertura = value; }
        }

        public DateTime horaCierre
        {
            get { return _horaCierre; }
            set { _horaCierre = value; }
        }


        /*
        public int getDuracionExposicion(Exposicion exposicion)
        {

        }*/
    }
}
