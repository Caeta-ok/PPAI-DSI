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

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public int CantidadMaximaDeVisitantes { get => _cantidadMaximaVisitantes; set => _cantidadMaximaVisitantes = value; }
        public int CantidadMaximaDeVisitantesPorGuia { get => _cantidadMaximaPorGuia; set => _cantidadMaximaPorGuia = value; }
        public List<Exposicion> ListaExposiciones { get => _listaExposiciones; set => _listaExposiciones = value; }

        public Sede(SEDES sede)
        {
            Id = sede.Id_Sede;
            Nombre = sede.Nombre;
            CantidadMaximaDeVisitantesPorGuia = sede.CantidadMaximaPorGuia.Value;
            CantidadMaximaDeVisitantes = sede.CantidadMaximaVisitantes.Value;
        }

        public Sede(int id, string nom, int cant_max_vi, int cant_max_gui, List<Exposicion> list)
        {
            Id = id;
            Nombre = nom;
            CantidadMaximaDeVisitantes = cant_max_vi;
            CantidadMaximaDeVisitantesPorGuia = cant_max_gui;
            ListaExposiciones = list;
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
            Nombre = nombre;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setCantidadMaximaPorGuia(int cantidadMaximaPorGuia)
        {
            CantidadMaximaDeVisitantesPorGuia = cantidadMaximaPorGuia;
        }

        public int getCantidadMaximaPorGuia()
        {
            return CantidadMaximaDeVisitantesPorGuia;
        }

        public int getCantidadMaixmaVisitantes()
        {
            return CantidadMaximaDeVisitantes;
        }

        public void setCantidadMaximaVisitantes(int cantidadMaximaVisitantes)
        {
            CantidadMaximaDeVisitantes = cantidadMaximaVisitantes;
        }

        public void setExposicion(Exposicion exposicion)
        {
            ListaExposiciones.Add(exposicion);
        }

        public List<Exposicion> getExposiciones()
        {
            return ListaExposiciones;
        }

        public int getDuracionDeExposicion(List<Exposicion> expo_seleccionadas)
        {
            int duracionDeExposicion = 0;
            foreach (Exposicion exposicion in expo_seleccionadas)
            {
                duracionDeExposicion += exposicion.calcularDuracionObrasExpuestas();
            }
            return duracionDeExposicion;
        }

        public List<Reserva> buscarReservasPorFecha(DateTime fecha)
        {
            List<Reserva> listaReservas = Persistencia.traerReservasPorIdSede(_id);
            foreach (Reserva res in listaReservas)
            {
                if (res.getFechaReserva() == fecha)
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
            foreach (Reserva res in listaReservas)
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