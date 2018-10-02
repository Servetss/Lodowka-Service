using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LodowkaSerwice.Models
{
    public class Lodoweczka
    {
        public int Id { get; set; }
        public int UzytkownikID { get; set; }
        public string SpisIdProduktow { get; set; }
        public string SpisIlosciProduktow { get; set; }
    }
}