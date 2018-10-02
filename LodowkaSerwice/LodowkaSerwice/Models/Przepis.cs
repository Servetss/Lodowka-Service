using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LodowkaSerwice.Models
{
    public class Przepis
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Spis_produktow { get; set; }
        public string Ilosci_produktow { get; set; }
        public string Opis { get; set; }
        public double Popularnosc { get; set; }
        public bool Zatwierdzony { get; set; }
    }
}