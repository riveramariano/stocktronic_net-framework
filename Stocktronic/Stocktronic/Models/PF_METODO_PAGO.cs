//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stocktronic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PF_METODO_PAGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PF_METODO_PAGO()
        {
            this.PF_INFO_PAGO = new HashSet<PF_INFO_PAGO>();
        }
    
        public long ID_METODOPAGO { get; set; }
        public string METP_NOMBRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PF_INFO_PAGO> PF_INFO_PAGO { get; set; }
    }
}
