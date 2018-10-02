using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LodowkaSerwice.Models;

namespace LodowkaSerwice.DAL
{
    public class LodowkaContext : DbContext
    {

        public LodowkaContext() : base("LodowkaContext")
        {

        }
        public DbSet<Produkt> setProdukty { get; set; }
        public DbSet<Przepis> setPrzepisy { get; set; }
        public DbSet<Uzytkownik> setUzytkownicy { get; set; }
        public DbSet<Lodoweczka> setLodowki { get; set; }
        public DbSet<Komentarz> setKomentarze { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}