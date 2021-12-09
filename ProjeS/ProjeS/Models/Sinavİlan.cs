//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Sinavİlan
    {
        public int SinavIlanNo { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]
        public System.DateTime tarih { get; set; }
        public Nullable<int> DersId { get; set; }
        public Nullable<int> sinifId { get; set; }
        public Nullable<int> saatId { get; set; }
        public Nullable<int> kullaniciId { get; set; }
        public Nullable<int> salonId { get; set; }

        [DataType(DataType.Text)]
        public string açıklama { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Kullanicis Kullanicis { get; set; }
        public virtual Saats Saats { get; set; }
        public virtual Salons Salons { get; set; }
        public virtual Sinifs Sinifs { get; set; }
    }
}
