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
    
    public partial class Bolum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolum()
        {
            this.Personel = new HashSet<Personel>();
        }
    
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }
        public int SirketId { get; set; }
    
        public virtual Sirket Sirket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
