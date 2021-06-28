using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Empleado
    {
        //public int id { get; set; }
        //public string nombre { get; set; }
        //public string apellido { get; set; }
        //public string email { get; set; }
        //public DateTime horaEntrada { get; set; }
        //public DateTime horaSalida { get; set; }

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _email;
        private Int64 _nroTelefono;
        private HorarioTrabajo _horarioTrabajo;
        private Cargo _cargo;

        public Empleado(EMPLEADOS empleado)
        {
            _id = empleado.Id_Empleado;
            _nombre = empleado.Nombre;
            _apellido = empleado.Apellido;
            _email = empleado.Email;
            _nroTelefono = empleado.NroTelefono.Value;
        }

        public void conocerCargo(Cargo cargo)
        {
            _cargo = cargo;
        }

        public void conocerHorario(HorarioTrabajo horarioTrabajo)
        {
            _horarioTrabajo = horarioTrabajo;
        }

        public int getId()
        {
            return _id;
        }
    }
}
