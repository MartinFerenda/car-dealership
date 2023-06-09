﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdreseLib
{
    public class Adrese
    {
        public int IDAdrese { get; set; }
        public string Broj { get; set; }
        public string Ulica { get; set; }
        public string Mjesto { get; set; }
        public string NazivPodruznice { get; set; }
        public string PostanskiBroj { get; set; }
        public string OpisPodruznice { get; set; }
        public TimeSpan? RadnoVrijemeOd { get; set; }
        public TimeSpan? RadnoVrijemeDo { get; set; }

        public Adrese()
        {

        }
        public Adrese(string broj, string ulica, string mjesto)
        {
            Broj = broj;
            Ulica = ulica;
            Mjesto = mjesto;
        }
        public override string ToString()
        {
            return NazivPodruznice + " " + Ulica + " " + Broj;
        }
    }
}
