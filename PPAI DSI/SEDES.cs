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
    
    public partial class SEDES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEDES()
        {
            this.RESERVAS = new HashSet<RESERVAS>();
        }
    
        public int Id_Sede { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CantidadMaximaVisitantes { get; set; }
        public Nullable<int> CantidadMaximaPorGuia { get; set; }
        public Nullable<int> Id_Exposicion { get; set; }
    
        public virtual EXPOSICIONES EXPOSICIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVAS> RESERVAS { get; set; }
    }
}
