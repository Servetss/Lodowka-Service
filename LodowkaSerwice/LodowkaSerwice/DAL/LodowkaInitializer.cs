using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LodowkaSerwice.Models;

namespace LodowkaSerwice.DAL
{
    public class LodowkaInitializer : DropCreateDatabaseIfModelChanges<LodowkaContext>
    {
        protected override void Seed(LodowkaContext context)
        {
            var uzytkownicy = new List<Uzytkownik>
            {
                new Uzytkownik{Id = 1, Login = "Doter", Haslo = "Nature", Imie = "Ivanna", Nazwisko = "Andriishyn", Email = "ivandriishyn@gmail.com", SuperUser = true},
                new Uzytkownik{Id = 2, Login = "Visual", Haslo = "Pass", Imie = "Mykola", Nazwisko = "Fedorenko", Email = "mykolafedorenko@gmail.com", SuperUser = true},
                new Uzytkownik{Id = 3, Login = "GodFather", Haslo = "Chamiak", Imie = "Andrzej", Nazwisko = "Hataliak", Email = "andrzejhataliak@gmail.com", SuperUser = true},
                new Uzytkownik{Id = 4, Login = "Haker228", Haslo = "ded", Imie = "Kostia", Nazwisko = "Mangal", Email = "GPietrucha@gmail.com", SuperUser = false},
                new Uzytkownik{Id = 5, Login = "Kirpicz", Haslo = "rajonczik", Imie = "Grisza", Nazwisko = "Makrucha", Email = "GPietrucha@gmail.com", SuperUser = false}
            };
            uzytkownicy.ForEach(u => context.setUzytkownicy.Add(u));
            context.SaveChanges();

            var produkty = new List<Produkt>
            {
                new Produkt{Id = 1, Nazwa = "Acai", Kalorie = 70, Wyd = "Owoce"},
                new Produkt{Id = 2, Nazwa = "Agrest", Kalorie = 44, Wyd = "Owoce"},
                new Produkt{Id = 3, Nazwa = "Ananas", Kalorie = 50, Wyd = "Owoce"},
                new Produkt{Id = 4, Nazwa = "Arbuz", Kalorie = 30, Wyd = "Owoce"},
                new Produkt{Id = 5, Nazwa = "Awokado", Kalorie = 160, Wyd = "Owoce"},
                new Produkt{Id = 6, Nazwa = "Banan", Kalorie = 89, Wyd = "Owoce"},
                new Produkt{Id = 7, Nazwa = "Banan rajski", Kalorie = 122, Wyd = "Owoce"},
                new Produkt{Id = 8, Nazwa = "Brzoskwinia", Kalorie = 39, Wyd = "Owoce"},
                new Produkt{Id = 9, Nazwa = "Cytryna", Kalorie = 29, Wyd = "Owoce"},
                new Produkt{Id = 10, Nazwa = "Czereśni", Kalorie = 63, Wyd = "Owoce"},
                new Produkt{Id = 11, Nazwa = "Daktyle", Kalorie = 282, Wyd = "Owoce"},
                new Produkt{Id = 12, Nazwa = "Dżakfrut", Kalorie = 95, Wyd = "Owoce"},
                new Produkt{Id = 13, Nazwa = "Figi", Kalorie = 74, Wyd = "Owoce"},
                new Produkt{Id = 14, Nazwa = "Granat", Kalorie = 83, Wyd = "Owoce"},
                new Produkt{Id = 15, Nazwa = "Gruszka", Kalorie = 57, Wyd = "Owoce"},
                new Produkt{Id = 16, Nazwa = "Gujawa", Kalorie = 82, Wyd = "Owoce"},
                new Produkt{Id = 17, Nazwa = "Jabłko", Kalorie = 43, Wyd = "Owoce"},
                new Produkt{Id = 18, Nazwa = "Kasza gryczana", Kalorie = 343, Wyd = "Zboża i produkty zbożowe"},
                new Produkt{Id = 19, Nazwa = "Pierś z kurczaka", Kalorie = 172, Wyd = "Drób i ptactwo"},
                new Produkt{Id = 20, Nazwa = "Papryka czerwona", Kalorie = 251, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 21, Nazwa = "Papryka żołta", Kalorie = 251, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 22, Nazwa = "Papryka zielona", Kalorie = 251, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 23, Nazwa = "Marchewka", Kalorie = 41, Wyd = "Warzywa"},
                new Produkt{Id = 24, Nazwa = "Bakłażan", Kalorie = 25, Wyd = "Warzywa"},
                new Produkt{Id = 25, Nazwa = "Oliwa z oliwek", Kalorie = 884, Wyd = "Oleje I tłuszcze"},
                new Produkt{Id = 26, Nazwa = "Miód płynny", Kalorie = 286, Wyd = "Pasty"},
                new Produkt{Id = 27, Nazwa = "Papryka słodka mielona", Kalorie = 251, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 28, Nazwa = "Oregano", Kalorie = 265, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 29, Nazwa = "Ser feta", Kalorie = 342, Wyd = "Ser topiony"},
                new Produkt{Id = 30, Nazwa = "Burak", Kalorie = 43, Wyd = "Warzywa"},
                new Produkt{Id = 31, Nazwa = "Cebula", Kalorie = 40, Wyd = "Zioła i przyprawy"},
                new Produkt{Id = 32, Nazwa = "Gulasz wołowy", Kalorie = 0, Wyd = "Wołowina i cielęcina"},
                new Produkt{Id = 33, Nazwa = "Ziemniak", Kalorie = 77, Wyd = "Produkty ziemniaczane"},
                new Produkt{Id = 34, Nazwa = "Czosnek", Kalorie = 149, Wyd = "Warzywa"},
                new Produkt{Id = 35, Nazwa = "Woda", Kalorie = 0, Wyd = "Napoje bezalkoholowe i napitki"}
            };
            produkty.ForEach(p => context.setProdukty.Add(p));
            context.SaveChanges();

            var przepisy = new List<Przepis>
            {
                //new Przepis{Id = 1, Nazwa = "Barszcz Ukrainski", Spis_produktow = "2 litry wody, 2 buraki, 1 cebula, 1 pęczek włoszczyzny, 5 ziemniaków, 1 duża garść ugotowanej białej fasoli, 250 g mięsa, 2-3 pomidory lub łyżka koncentratu pomidorowego, 1 kwaśne jabłko, sok z cytryny, sól, pieprz, cukier do smaku, śmietana 22%, świeży koperek, ew. koncentrat buraczany", Opis = "Postep przygotowania i td.", Popularnosc = 4, Zatwierdzony = true},
                new Przepis{Id = 1, Nazwa = "Barszcz Ukrainski", Spis_produktow = "35,30,31,23,33,32", Ilosci_produktow = "2000,150,50,100,300,250", Opis = "Postep przygotowania i td.", Popularnosc = 4, Zatwierdzony = true},
                //new Przepis{Id = 2, Nazwa = "Kasza greczana z kurczakiem, bakłażanem, papryką, machewką, z dodatkiem fety", Spis_produktow = "200g Kasza greczana, 500g pierś z kurczaka, 0.5 papryka żułta, 0.5 papryka żelona, 1 morkwa, 1 baklażan, oliwa z oliwek, 20ml miód płynny, 5g papryka słodka mielona, 20ml oregano, sól, piepsz, ser feta ", Opis = "Postep przygotowania i td.", Popularnosc = 3, Zatwierdzony = true},
                new Przepis{Id = 2, Nazwa = "Kasza greczana z kurczakiem, bakłażanem, papryką, machewką, z dodatkiem fety", Spis_produktow = "18,19,21,22,23,24,25,26,27,28,29,", Ilosci_produktow = "200,500,25,25,100,350,30,20,5,20,300,", Opis = "Postep przygotowania i td.", Popularnosc = 3, Zatwierdzony = true},
                //new Przepis{Id = 3, Nazwa = "Zła zupa", Spis_produktow = "zgniłe ziemniaki i kapusta", Opis = "Wyrzucić do śmietnika", Popularnosc = 0, Zatwierdzony = false}
                new Przepis{Id = 3, Nazwa = "Zła zupa", Spis_produktow = "33,31,35", Ilosci_produktow = "100,200,500", Opis = "Wyrzucić do śmietnika", Popularnosc = 0, Zatwierdzony = false}
            };
            przepisy.ForEach(p => context.setPrzepisy.Add(p));
            context.SaveChanges();

            var komentarze = new List<Komentarz>
            {
                new Komentarz{Id = 1, UzytkownikID = 4, PrzepisID = 1, Koment = "Tuchlaja ryba i ananas z mentosom"},
                new Komentarz{Id = 1, UzytkownikID = 5, PrzepisID = 2, Koment = "Tuchlaja ryba i ananas z mentosom"},
            };
            komentarze.ForEach(k => context.setKomentarze.Add(k));
            context.SaveChanges();

            var lodowki = new List<Lodoweczka>
            {
                new Lodoweczka{Id = 1, UzytkownikID = 4, SpisIdProduktow = "1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,", SpisIlosciProduktow = "100,15,159,123,15,100,15,159,123,15,100,15,159,123,15,"},
                new Lodoweczka{Id = 2, UzytkownikID = 5, SpisIdProduktow = "2,4,6,8,10,12,14,16,18,20,22,24,26,28,", SpisIlosciProduktow = "100,15,159,123,15,100,15,159,123,15,100,15,159,123,"}
            };
            lodowki.ForEach(l => context.setLodowki.Add(l));
            context.SaveChanges();
        }
    }
}