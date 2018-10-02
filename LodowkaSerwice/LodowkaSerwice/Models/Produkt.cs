using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LodowkaSerwice.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Kalorie { get; set; }
        public string Wyd { get; set; }
    }
}