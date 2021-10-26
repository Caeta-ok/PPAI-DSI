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
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _email;
        private Int64 _nroTelefono;
        private HorarioTrabajo _horarioTrabajo;
        private Cargo _cargo;
        private Sede _sedeDondeTrabaja;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public Int64 NroTelefono { get => _nroTelefono; set => _nroTelefono = value; }
        public HorarioTrabajo HorarioTrabajo { get => _horarioTrabajo; set => _horarioTrabajo = value; }
        public Cargo Cargo { get => _cargo; set => _cargo = value; }
        public Sede SedeDondeTrabaja { get => _sedeDondeTrabaja; set => _sedeDondeTrabaja = value; }

        public Empleado(EMPLEADOS empleado) // El tipo EMPLEADO es un objeto del ORM
        {
            Id = empleado.Id_Empleado;
            Nombre = empleado.Nombre;
            Apellido = empleado.Apellido;
            Email = empleado.Email;
            NroTelefono = empleado.NroTelefono.Value;
            // No se incluye los objetos HorarioTrabajo y Cargo 
            // porque el ORM solo entrega el Id (int) correspondiente
            // a la llave foránea
        }

        public bool esDeSede(Sede sede)
        {
            if(this.SedeDondeTrabaja.Nombre == sede.Nombre)
                return true;
            return false;
        }

        public bool esGuia()
        {
            return this.Cargo.esGuia();
        }
    }
}
