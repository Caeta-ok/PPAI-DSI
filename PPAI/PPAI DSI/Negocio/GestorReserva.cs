using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using PPAI_DSI.Formularios;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public static class GestorReserva
    {
        //private static Sede _sedeSeleccionada;
        private static List<Escuela> _listaEscuelas;
        private static Reserva _reserva;
        private static List<Sede> _listaSedes;
        private static List<TipoVisita> _listaTiposVisitas;
        private static TipoVisita _tipoVisitaSeleccionada;
        private static Sede _sedeSeleccionada;
        private static List<Exposicion> _listaExposicionesTemporales;
        private static List<Exposicion> _listaExposicionesTemporalesSeleccionadas = new List<Exposicion>();

        public static void buscarEscuelas()
        {
            _listaEscuelas = Persistencia.traerEscuelas(); 
        }

        public static void nuevaReserva()
        {
            _reserva = new Reserva();
        }
        public static List<Escuela> getListaEscuelas()
        {
            return _listaEscuelas;
        }

        public static void tomarSeleccionEscuela(int id)
        {
            int aux = id;
        }

        public static void tomarNumeroVisitantes(int numeroVisitantes)
        {
            int aux = numeroVisitantes;
            buscarSedes(numeroVisitantes);
        }

        private static void buscarSedes(int numeroVisitantes)
        {
            _listaSedes = Persistencia.traerSedesPorCapacidadVisitantes(numeroVisitantes);
        }

        public static List<Sede> getSedes()
        {
            return _listaSedes;
        }

        public static void tomarSeleccionSede(int Id_Sede)
        {
            int aux = Id_Sede;
            foreach(Sede sede in _listaSedes)
            {
                if(sede.getId() == Id_Sede)
                {
                    _sedeSeleccionada = sede;
                }
            }
            buscarTipoVisita();
        }

        private static void buscarTipoVisita()
        {
            _listaTiposVisitas = Persistencia.traerTipoVisita();
        }

        public static List<TipoVisita> getTiposVisitas()
        {
            return _listaTiposVisitas;
        }

        public static void tomarSeleccionTipoVisita(int id)
        {
            _listaExposicionesTemporales = new List<Exposicion>();
            foreach (TipoVisita tipoVisita in _listaTiposVisitas)
            {
                if(tipoVisita.getNombre() == "Por exposicion")
                {
                    _tipoVisitaSeleccionada = tipoVisita;
                    buscarExposicionesTemporales();
                }
            }
        }

        public static void buscarExposicionesTemporales()
        {
            foreach (Exposicion expo in _sedeSeleccionada.getExposiciones()) // Para la sede seleccionada recorrer todas las exposiciones
            {
                if (expo.getTipoExposicion().getNombre() == "Temporal") // Si es temporal
                {
                    if (expo.esVigente()) // Si es vigente
                    {
                        _listaExposicionesTemporales.Add(expo);
                    }
                }
            }
        }

        public static List<Exposicion> getExposicionesTemporales()
        {
            return _listaExposicionesTemporales;
        }

        public static void tomarSeleccionExposicion(List<int> listaIdExposiciones)
        {
            
            _listaExposicionesTemporalesSeleccionadas.Clear();
            foreach(int idExpo in listaIdExposiciones)
            {
                foreach (Exposicion expo in _listaExposicionesTemporales)
                {
                    if(expo.getId() == idExpo)
                    {
                        _listaExposicionesTemporalesSeleccionadas.Add(expo);
                    }
                }
            }
        }

        public static void tomarFechaReserva(DateTime fechaReserva)
        {
            _reserva.setFechaReserva(fechaReserva);
        }

        public static void tomarHoraReserva(DateTime horaReserva)
        {
            _reserva.setHoraReserva(horaReserva);
            calcularDuracionReserva();

        }

        private static void calcularDuracionReserva()
        {
            _reserva.setDuracionEstimada(_sedeSeleccionada.getDuracionDeExposicion());
        }

        public static int getDuracionEstimada()
        {
            return _reserva.getDuracionEstimada();
        }

        public static bool validarCapacidadVisitantes()
        {
            int cantidadTotal = _reserva.getCantidadAlumnos() + _sedeSeleccionada.sumarCantidadDeVisitantes(_reserva.getFechaReserva());
            if (cantidadTotal <= _sedeSeleccionada.getCantidadMaixmaVisitantes())
                return true;
            return false;
        }

        public static bool buscarGuiasDispFechaReserva() // Los guias tienen que pertenecer a las sedes
        {
            List<Empleado> listaGuias = Persistencia.traerEmpeladosGuias();
            List<AsignacionVisita> listaAsignacionesVisitas = Persistencia.traerAsignacionesVisita();
            foreach(Empleado guia in listaGuias)
            {

            }
        }




        //GestorReserva()
        //{
            
        //}
        /*
        public List<Sede> buscarSedes()
        {
            
        }*/

        //public void tomarSeleccionReserva(Sede sede)
        //{
        //    _sedeSeleccionada = sede;
        //}
        /*
        public int calcularDuracionReserva()
        {
            // Devuelve la duración en minutos

        }*/
    }
}
