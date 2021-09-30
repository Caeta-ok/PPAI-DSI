using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Escuela
    {
        private int _id;
        private string _nombre;
        private string _email;
        private Int64 _telefonoCelular;
        private string _domicilio;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }
        public Int64 TelefonoCelular { get => _telefonoCelular; set => _telefonoCelular = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }

        public Escuela(ESCUELAS escuela)
        {
            Id = escuela.Id_Escuela;
            Nombre = escuela.Nombre;
            Email = escuela.Email;
            TelefonoCelular = escuela.NroTelefono.Value;
            Domicilio = escuela.Domicilio;
        }
    }
}