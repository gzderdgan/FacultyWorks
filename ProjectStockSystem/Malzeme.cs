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
    
    public partial class Malzeme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Malzeme()
        {
            this.OgrenciSecilenMalzemeVeZamani = new HashSet<OgrenciSecilenMalzemeVeZamani>();
        }
    
        public int malzeme_id { get; set; }
        public string malzeme_adi { get; set; }
        public int malzeme_calisma_grubu { get; set; }
        public int malzeme_durumu { get; set; }
        public string malzeme_serino { get; set; }
        public string malzeme_kodu { get; set; }
        public int malzeme_tipi { get; set; }
    
        public virtual MalzemeDurumu MalzemeDurumu { get; set; }
        public virtual MalzemeTipi MalzemeTipi { get; set; }
        public virtual OgrenciCalismaTuru OgrenciCalismaTuru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciSecilenMalzemeVeZamani> OgrenciSecilenMalzemeVeZamani { get; set; }
    }
}
