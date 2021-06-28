using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Reserva
    {
        private int _id;
        private int _duracionEstimada;
        private DateTime _fechaHoraCreacion;
        private DateTime _fechaReserva;
        private DateTime _horaReserva;
        private DateTime _horaInicioReal;
        private DateTime _horaFinReal;
        private int _cantidadAlumnos;
        private int _cantidadAlumnosConfirmados;
        private Sede _sede;
        private List<Exposicion> _listaExposiciones = new List<Exposicion>();
        private List<Empleado> _listaEmpleadosGuia = new List<Empleado>();
        private List<AsignacionVisita> _listaAsignacionesVisita = new List<AsignacionVisita>();
        private CambioEstado _cambioEstado;
        private Escuela _escuela;

        public Reserva(RESERVAS reserva)
        {
            _id = reserva.Id_Reserva;
            _duracionEstimada = reserva.DuracionEstimada.Value;
            _fechaHoraCreacion = reserva.FechaHoraCreacion.Value;
            _fechaReserva = reserva.FechaReserva.Value;
            _horaReserva = DateTime.Parse(reserva.HoraReserva.Value.ToString());
            _horaInicioReal = DateTime.Parse(reserva.HoraInicioReal.Value.ToString());
            _horaFinReal = DateTime.Parse(reserva.HoraFinReal.Value.ToString());
            _cantidadAlumnos = reserva.CantidadAlumnos.Value;
            _cantidadAlumnosConfirmados = reserva.CantidadAlumnosConfirmados.Value;
        }

        public Reserva() { }

        public void conocerAsignacionVisita(AsignacionVisita asignacionVisita)
        {
            _listaAsignacionesVisita.Add(asignacionVisita);
            conocerEmpleado(asignacionVisita.getEmpleado());
        }

        public void conocerCambioEstado(CambioEstado cambioEstado)
        {
            _cambioEstado = cambioEstado;
        }

        public void conocerEmpleado(Empleado empleado)
        {
            _listaEmpleadosGuia.Add(empleado);
        }

        public void conocerEscuela(Escuela escuela)
        {
            _escuela = escuela;
        }

        public void conocerExposicion(Exposicion exposicion)
        {
            _listaExposiciones.Add(exposicion);
        }

        public void conocerSede(Sede sede)
        {
            _sede = sede;
        }

        public void setEscuela(Escuela escuela)
        {
            _escuela = escuela;
        }

        public void setCantidadAlumnos(int cantidadAlumnos)
        {
            _cantidadAlumnos = cantidadAlumnos;
        }

        public void setSede(Sede sede)
        {
            _sede = sede;
        }

        public void setHoraInicioReal(DateTime horaInicio)
        {
            _horaInicioReal = horaInicio;
        }

        public void setFechaReserva(DateTime fechaReserva)
        {
            _fechaReserva = fechaReserva;
        }

        public void setHoraReserva(DateTime horaReserva)
        {
            _horaReserva = horaReserva;
        }

        public void setDuracionEstimada(int duracion)
        {
            _duracionEstimada = duracion;
        }

        public int getDuracionEstimada()
        {
            return _duracionEstimada;
        }

        public DateTime getFechaReserva()
        {
            return _fechaReserva;
        }

        public int getCantidadAlumnosConfirmados()
        {
            return _cantidadAlumnosConfirmados;
        }

        public int getCantidadAlumnos()
        {
            return _cantidadAlumnos;
        }
    }
}
