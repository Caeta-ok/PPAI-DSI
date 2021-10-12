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

        public Sede(SEDES sede) // SEDE es un tipo del ORM
        {
            Id = sede.Id_Sede;
            Nombre = sede.Nombre;
            CantidadMaximaDeVisitantesPorGuia = sede.CantidadMaximaPorGuia.Value;
            CantidadMaximaDeVisitantes = sede.CantidadMaximaVisitantes.Value;

            // No se incluyen las exposiciones porque el ORM
            //solo devuelve el id de la llave foránea (int)
        }

        public Sede(){}

        public void conocerExposicion(Exposicion exposicion)
        {
            ListaExposiciones.Add(exposicion);
        }

        public int getDuracionDeExposicion(List<Exposicion> exposicionesSeleccionadas)
        {
            //Se calcula con la duración extendida
            int duracionDeExposicion = 0;
            foreach (Exposicion exposicion in exposicionesSeleccionadas)
            {
                duracionDeExposicion += exposicion.calcularDuracionExtendida();
            }
            return duracionDeExposicion;
        }

        public List<int> getCantidadVisitantesEnReservasPorFecha(DateTime fecha)
        {
            List<Reserva> listaReservas = Persistencia.traerReservas();

            List<int> listaCantidadesVisitantes = new List<int>();
            foreach (Reserva reserva in listaReservas) // Loop Mientras existan reservas
            {
                if(reserva.esDeSede(this.Id)) // Si es de esta sede
                {
                    if (reserva.esDeFecha(fecha)) // Si coincide con la fecha
                    {
                        listaReservas.Add(reserva);
                        listaCantidadesVisitantes.Add(reserva.CantidadAlumnos);
                    }
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

        public int getCantidadGuiasNecesarios(int alumnos)
        {
            double cantidadNecesaria = Math.Round(Convert.ToDouble(alumnos / CantidadMaximaDeVisitantesPorGuia));
            return (int)cantidadNecesaria;
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