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
    
    public partial class TBLSATIS
    {
        public int SATISID { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> ECZANE { get; set; }
        public Nullable<int> SATISADET { get; set; }
        public Nullable<int> ILAC { get; set; }
    
        public virtual TBLECZANE TBLECZANE { get; set; }
        public virtual TBLILAC TBLILAC { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
    }
}
