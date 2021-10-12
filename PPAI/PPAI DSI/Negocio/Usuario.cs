using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Usuario
    {
        private int _id;
        public string _nombre;
        public string _contrasenia;
        private Empleado _empleado;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }

        public Usuario(USUARIOS usuario)
        {
            Id = usuario.Id_Usuario;
            Nombre = usuario.Nombre;
            Contrasenia = usuario.Contrasenia;
        }
    }
}
