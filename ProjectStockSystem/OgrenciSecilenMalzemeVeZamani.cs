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
    
    public partial class OgrenciSecilenMalzemeVeZamani
    {
        public int kullanıcı_id { get; set; }
        public int secilen_malzeme_id { get; set; }
        public System.DateTime kullanici_alis_tarihi { get; set; }
        public System.DateTime kullanici_teslim_tarihi { get; set; }
        public string kullanici_telefon { get; set; }
    
        public virtual Malzeme Malzeme { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
