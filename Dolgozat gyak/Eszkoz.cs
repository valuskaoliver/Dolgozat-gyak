using System;
using System.Collections.Generic;
using System.Text;

namespace Dolgozat_gyak
{
    internal class Eszkoz
    {
        private int napiDij;
        private int keszlet;
        private static int osszesRegisztraltEszkoz = 0;

        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string Kategori { get; set; }
        
        public int NapiDij { get => napiDij;
            set => napiDij = value < 0 ? 0 : value;
        }
        public int Keszlet {
            get => keszlet;
            set => keszlet = value < 1 ? 1 : value;
        }
        public static int OsszesRegisztraltEszkoz { get => osszesRegisztraltEszkoz; } 

        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij) : this (azonosito, nev, kategoria, napiDij, 1)
        {

        }

        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij, int keszlet) 
        {
            Azonosito = azonosito;
            Nev = nev;
            Kategori = kategoria;
            NapiDij = napiDij;
            Keszlet = keszlet;
            osszesRegisztraltEszkoz++;
        }

        public override string ToString()
        {
            return $"[{Azonosito}] {Nev} ({Kategori}) - Napi díj: {NapiDij} Ft | Készlet: {Keszlet} db";
        }

        public int TeljesNapiBevetel()
        {
            return NapiDij * Keszlet;
        }
        public bool KategoriaEgyezik(string keresettKategoria)
        {
            return keresettKategoria == Kategori;
        }
    }
}
