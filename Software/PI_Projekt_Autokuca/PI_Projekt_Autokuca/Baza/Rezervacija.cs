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
    
    public partial class Rezervacija
    {
        public int IdRezervacije { get; set; }
        public string Status { get; set; }
        public System.DateTime DatumIVrijeme { get; set; }
        public string PredmetRezervacije { get; set; }
        public System.DateTime PocetakRezervacije { get; set; }
        public System.DateTime KrajRezervacije { get; set; }
        public int Korisnik { get; set; }
        public int Vozilo { get; set; }
        public int Adresa { get; set; }
    
        public virtual Adresa Adresa1 { get; set; }
        public virtual Korisnik Korisnik1 { get; set; }
        public virtual Vozilo Vozilo1 { get; set; }
    }
}
