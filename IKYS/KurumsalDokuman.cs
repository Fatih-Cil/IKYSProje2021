//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IKYS
{
    using System;
    using System.Collections.Generic;
    
    public partial class KurumsalDokuman
    {
        public int KdId { get; set; }
        public string KdPath { get; set; }
        public int SirketId { get; set; }
        public int KDKId { get; set; }
    
        public virtual KDKategori KDKategori { get; set; }
        public virtual Sirket Sirket { get; set; }
    }
}
