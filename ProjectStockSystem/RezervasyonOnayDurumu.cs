//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectStockSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class RezervasyonOnayDurumu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RezervasyonOnayDurumu()
        {
            this.OgrenciRezervasyonDurumu = new HashSet<OgrenciRezervasyonDurumu>();
        }
    
        public int onay_id { get; set; }
        public string onay_durumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciRezervasyonDurumu> OgrenciRezervasyonDurumu { get; set; }
    }
}
