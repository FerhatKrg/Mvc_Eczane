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

    public partial class TBLILAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLILAC()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int ID { get; set; }

        [Required(ErrorMessage ="Lütfen Bir İlaç Adı Giriniz ... ")]
        public string ILACADI { get; set; }

        [Required(ErrorMessage = "Kategori Alanı Boş Geçilemez ... ")]
        public Nullable<byte> KATEGORİ { get; set; }
        public Nullable<int> STOK { get; set; }
        public Nullable<int> FIYAT { get; set; }
    
        public virtual TBLKATEGORI TBLKATEGORI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
