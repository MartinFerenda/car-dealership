//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_Projekt_Autokuca.Baza
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarkaVozila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarkaVozila()
        {
            this.Voziloes = new HashSet<Vozilo>();
        }
    
        public int IdMarke { get; set; }
        public string NazivMarkeIModela { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vozilo> Voziloes { get; set; }
    }
}
