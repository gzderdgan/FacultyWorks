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
    
    public partial class OgrenciRezervasyonDurumu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OgrenciRezervasyonDurumu()
        {
            this.OgrenciRezervasyonİliskisi = new HashSet<OgrenciRezervasyonİliskisi>();
        }
    
        public int rezervasyon_id { get; set; }
        public string rezervasyon_durumu { get; set; }
        public int rezervasyon_onay_durumu { get; set; }
        public int rezervasyon_teslim_durumu { get; set; }
    
        public virtual DepocuTeslimDurumu DepocuTeslimDurumu { get; set; }
        public virtual RezervasyonOnayDurumu RezervasyonOnayDurumu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciRezervasyonİliskisi> OgrenciRezervasyonİliskisi { get; set; }
    }
}
