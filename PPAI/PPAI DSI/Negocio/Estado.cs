using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class Estado
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _ambito;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Ambito { get => _ambito; set => _ambito = value; }

        public Estado(ESTADOS estado)
        {
            Id = estado.Id_Estado;
            Nombre = estado.Nombre;
            Descripcion = estado.Descripcion;
            Ambito = estado.Ambito;
        }

        public bool esAmbitoReserva()
        {
            if (this.Ambito == "Reservas")
                return true;
            return false;
        }

        public bool esPendienteDeConfirmacion()
        {
            if (this.Nombre == "Pendiente de confirmacion")
                return true;
            return false;
        }
    }
}
