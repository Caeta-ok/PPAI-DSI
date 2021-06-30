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

        public Usuario(USUARIOS usuario)
        {
            _id = usuario.Id_Usuario;
            _nombre = usuario.Nombre;
            _contrasenia = usuario.Contrasenia;
        }

        public void conocerEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public int getId()
        {
            return _id;
        }

        public Empleado getEmpleadoLogeado()
        {
            return _empleado;
        }
    }
}
