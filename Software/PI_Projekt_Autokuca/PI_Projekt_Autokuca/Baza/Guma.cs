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
    
    public partial class Guma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guma()
        {
            this.StavkaRacunaGumas = new HashSet<StavkaRacunaGuma>();
        }
    
        public int IdGume { get; set; }
        public int SifraGume { get; set; }
        public int Sirina { get; set; }
        public int Visina { get; set; }
        public int Promjer { get; set; }
        public Nullable<decimal> NabavnaCijena { get; set; }
        public Nullable<decimal> ProdajnaCijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public Nullable<int> Korisnik { get; set; }
        public int Proizvodac { get; set; }
    
        public virtual Korisnik Korisnik1 { get; set; }
        public virtual Proizvodac Proizvodac1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaRacunaGuma> StavkaRacunaGumas { get; set; }
    }
}
