using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Sede
    {
        private int _id;
        private string _nombre;
        private int _cantidadMaximaVisitantes;
        private int _cantidadMaximaPorGuia;
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();

        public Sede(SEDES sede)
        {
            _id = sede.Id_Sede;
            _nombre = sede.Nombre;
            _cantidadMaximaPorGuia = sede.CantidadMaximaPorGuia.Value;
            _cantidadMaximaVisitantes = sede.CantidadMaximaVisitantes.Value;
        }
        public Sede()
        {

        }

        public void setId(int id)
        {
            _id = id;
        }

        public int getId()
        {
            return _id;
        }

        public void setNombre(string nombre)
        {
            _nombre = nombre;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public void setCantidadMaximaPorGuia(int cantidadMaximaPorGuia)
        {
            _cantidadMaximaPorGuia = cantidadMaximaPorGuia;
        }

        public int getCantidadMaximaPorGuia()
        {
            return _cantidadMaximaPorGuia;
        }

        public int getCantidadMaixmaVisitantes()
        {
            return _cantidadMaximaVisitantes;
        }

        public void setCantidadMaximaVisitantes(int cantidadMaximaVisitantes)
        {
            _cantidadMaximaVisitantes = cantidadMaximaVisitantes;
        }

        public void conocerExposicion(Exposicion exposicion)
        {
            _listaExposiciones.Add(exposicion);
        }

        public List<Exposicion> getExposiciones()
        {
            return _listaExposiciones;
        }

        public int getDuracionDeExposicion()
        {
            int duracionDeExposicion = 0;
            foreach(Exposicion exposicion in _listaExposiciones)
            {
                foreach(Obra obra in exposicion.getDetalleExposicion().getObras())
                {
                    duracionDeExposicion += obra.getDuracionExtendida();
                }
            }
            return duracionDeExposicion;
        }

        public List<Reserva> buscarReservasPorFecha(DateTime fecha)
        {
            List<Reserva> listaReservas = Persistencia.traerReservasPorIdSede(_id);
            foreach(Reserva res in listaReservas)
            {
                if(res.getFechaReserva() == fecha)
                {
                    listaReservas.Add(res);
                }
            }
            return listaReservas;
        }

        public int sumarCantidadDeVisitantes(DateTime fecha)
        {
            int cantidadAlumnos = 0;
            List<Reserva> listaReservas = buscarReservasPorFecha(fecha);
            foreach(Reserva res in listaReservas)
            {
                cantidadAlumnos += res.getCantidadAlumnosConfirmados();
            }
            return cantidadAlumnos;
        }

        public List<Empleado> buscarGuias()
        {
            List<Empleado> listaGuias = new List<Empleado>();
            listaGuias = Persistencia.traerEmpeladosGuiasPorIdSede(_id);
            return listaGuias;
        }


        //private List<Exposicion> _exposiciones;
        //private string _nombre;

        //public string nombre
        //{
        //    get { return _nombre; }
        //    set { _nombre = value; }
        //}

        //public void conocerExposicion(Exposicion exposicion)
        //{
        //    _exposiciones.Add(exposicion);
        //}

        //public Sede getSede()
        //{
        //    Sede sede = new Sede();
        //    sede.nombre = this.nombre;
        //    foreach(Exposicion e in _exposiciones)
        //    {
        //        sede.conocerExposicion(e);
        //    }
        //    return sede;
        //}

        /*
        public int calcularDuracionEstimada()
        {

        }*/
    }
}
