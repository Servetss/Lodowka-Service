using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LodowkaSerwice.Models
{
    public class Komentarz
    {
        public int Id { get; set; }
        public int UzytkownikID { get; set; }
        public int PrzepisID { get; set; }
        public string Koment { get; set; }
    }
}