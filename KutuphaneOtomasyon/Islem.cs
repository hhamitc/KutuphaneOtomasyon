//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Islem
    {
        public int IslemId { get; set; }
        public Nullable<int> AboneId { get; set; }
        public Nullable<int> KitapId { get; set; }
        public Nullable<int> GorevliId { get; set; }
        public Nullable<System.DateTime> AlisTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public Nullable<int> GunFarki { get; set; }
        public Nullable<decimal> IslemSonuUcret { get; set; }
    }
}
