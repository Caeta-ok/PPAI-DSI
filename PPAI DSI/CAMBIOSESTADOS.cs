//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPAI_DSI
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAMBIOSESTADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAMBIOSESTADOS()
        {
            this.RESERVAS = new HashSet<RESERVAS>();
        }
    
        public int Id_CambioEstado { get; set; }
        public Nullable<System.DateTime> FechaHoraInicio { get; set; }
        public Nullable<System.DateTime> FechaHoraFin { get; set; }
        public Nullable<int> Id_Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVAS> RESERVAS { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
    }
}
