using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Clases
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CodigoValidacion { get; set; }
        public long Cuit { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public long NroTelefono { get; set; }
        public int Id_Cargo { get; set; }
        public int Id_HorarioTrabajo { get; set; }
    }
}
