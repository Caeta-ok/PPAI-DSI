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
        private int _cantidadMaximaDeVisitantes;
        private int _cantidadMaximaDeVisitantesPorGuia;
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadMaximaDeVisitantes { get => _cantidadMaximaDeVisitantes; set => _cantidadMaximaDeVisitantes = value; }
        public int CantidadMaximaDeVisitantesPorGuia { get => _cantidadMaximaDeVisitantesPorGuia; set => _cantidadMaximaDeVisitantesPorGuia = value; }
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

        public Sede(){}

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

        public List<int> getCantidadVisitantesEnReservasPorFecha(DateTime fecha)
        {
            List<Reserva> listaReservas = Persistencia.traerReservasPorIdSede(_id); // corregir consulta sql
            List<int> listaCantidadesVisitantes = new List<int>();
            foreach (Reserva reserva in listaReservas) // Loop Mientras existan reservas
            {
                if (reserva.esDeFecha(fecha))
                {
                    listaReservas.Add(reserva);
                    listaCantidadesVisitantes.Add(reserva.CantidadAlumnos);
                }
            }
            return listaCantidadesVisitantes;
        }

        public int sumarCantidadDeVisitantesEnFecha(DateTime fecha)
        {
            int cantidadVisitantes = 0;
            List<int> listaCantidadesVisitantes = getCantidadVisitantesEnReservasPorFecha(fecha);
            foreach (int cantidad in listaCantidadesVisitantes)
            {
                cantidadVisitantes += cantidad;
            }
            return cantidadVisitantes;
        }

        public List<Empleado> buscarGuias()
        {
            List<Empleado> listaGuias = new List<Empleado>();
            listaGuias = Persistencia.traerEmpeladosGuiasPorIdSede(_id);
            return listaGuias;
        }

        public double getCantidadGuiasNecesarios(double alumnos)
        {
            return Math.Round(Convert.ToDouble(alumnos / CantidadMaximaDeVisitantesPorGuia));

        }

        public bool validarCapacidadVisitantes(DateTime fechaReserva, int cantidadVisitantes)
        {
            int cantidadTotal = cantidadVisitantes + sumarCantidadDeVisitantesEnFecha(fechaReserva);
            if (cantidadTotal <= _cantidadMaximaDeVisitantes)
                return true;
            return false;
        }
    }
}