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

        public Escuela(ESCUELAS escuela)
        {
            _id = escuela.Id_Escuela;
            _nombre = escuela.Nombre;
            _email = escuela.Email;
            _telefonoCelular = escuela.NroTelefono.Value;
            _domicilio = escuela.Domicilio;
        }

        public string getNombre()
        {
            return _nombre;
        }

        public int getId()
        {
            return _id;
        }
    }
}
