using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LodowkaSerwice.Models
{
    public class Uzytkownik
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public bool SuperUser { get; set; }
    }
}