//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Eczane.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLPERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPERSONEL()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int ID { get; set; }


        [Required(ErrorMessage = "Ad Alan� Bo� Ge�ilemez  ... ")]
        public string AD { get; set; }

        [Required(ErrorMessage = "SoyAd Alan� Bo� Ge�ilemez  ... ")]
        public string SOYAD { get; set; }
        public string TELEFON { get; set; }

        [Required(ErrorMessage = "Mail Alan� Bo� Ge�ilemez  ... ")]
        public string MAIL { get; set; }

        [StringLength(10,ErrorMessage = "L�tfen en fazla 10 karakterlik bir �ifre giriniz  ... ")]
        public string SIFRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
