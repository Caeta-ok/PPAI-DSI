using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Backend;

namespace PPAI_DSI.Negocio
{
    public class TipoVisita
    {
        private int _id;
        private string _nombre;

        public TipoVisita(TIPOSVISITA tipoVisita)
        {
            Id = tipoVisita.Id_TipoVisita;
            Nombre = tipoVisita.Nombre;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public int getId()
        {
            return Id;
        }

        public string getNombre()
        {
            return Nombre;
        }
    }
}