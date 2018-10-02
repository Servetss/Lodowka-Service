using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using LodowkaSerwice.DAL;
using LodowkaSerwice.Models;
using System.Net.Mail;
using System.Net;

namespace LodowkaSerwice
{
    public class Service1 : IService1
    {
        LodowkaContext bazaContext = new LodowkaContext();

        public List<PrzepisDaneAdmin> AdminWypiszNiezatwPrzepisy()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Daje możliwość zatwierdzić przepis
        /// </summary>
        /// <param name="id_admin">musi być administrator</param>
        /// <param name="id_przepis">niezatwierdzony przepis</param>
        /// <param name="zatwierdz">czy zatwierdzić</param>
        /// <returns>czy udało się</returns>
        public bool AdminZatwierdzPrzepis(int id_admin, int id_przepis, bool zatwierdz)
        {
            try
            {
                Uzytkownik super = bazaContext.setUzytkownicy.Where(u => u.Id == id_admin).SingleOrDefault();
                if (super.SuperUser == true)
                {
                    Przepis przepis = bazaContext.setPrzepisy.Where(p => p.Id == id_przepis).SingleOrDefault();
                    przepis.Zatwierdzony = zatwierdz;
                    bazaContext.SaveChanges();
                    return true;
                }
                else throw new FaultException("Uzytkownik niema takich uprawnien!");
            }
            catch (FaultException e)
            {
                throw new FaultException("Nie da rady!");
            }
        }//done

        public bool dodajNowyPrzepis(string nazwa, string opis, List<int> id_produktow, List<int> ilosci_produktow)
        {
            throw new NotImplementedException();
        }

        public bool DodajProdDoLodowki(int id_uzytkow, int id_lodowki, List<int> id_prod, List<int> ilosci)
        {
            throw new NotImplementedException();
        }

        public bool LajknijPrzepis(int id_uzutkownika, int id_przepisu)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Logowanie się do programu
        /// </summary>
        /// <param name="login">nie może być null</param>
        /// <param name="haslo">nie może być null</param>
        /// <returns>zwraca id użytkownika i parametr czy jest administratorem</returns>
        public SuperUzytkownikType Logowanie(string login, string haslo)
        {
            try
            {
                Uzytkownik uzytkownik = bazaContext.setUzytkownicy.Where(u => u.Login == login && u.Haslo == haslo).SingleOrDefault();
                SuperUzytkownikType super = new SuperUzytkownikType { Id_super = uzytkownik.Id, Status_super = uzytkownik.SuperUser };
                return super;
            }
            catch (FaultException e)
            {
                throw new FaultException("Taki użytkownik nie itnieje lub zle podane dane...");
            }

        }//done

        public int Logowanie_zapasowe(string login, string haslo)
        {
            throw new NotImplementedException();
        }//nie trzeba
        /// <summary>
        /// Zapis do bazy komentarza do przepisu
        /// </summary>
        /// <param name="id_uzytkownika">użytkownik</param>
        /// <param name="id_przepisu">przepis</param>
        /// <param name="komentarz">tekst komentarza</param>
        /// <returns>rezultat sukces lub niepowodzenie</returns>
        public bool NapiszKomentarz(int id_uzytkownika, int id_przepisu, string komentarz)
        {
            try
            {
                Komentarz koment = new Komentarz { UzytkownikID = id_uzytkownika, PrzepisID = id_przepisu, Koment = komentarz };
                bazaContext.setKomentarze.Add(koment);
                bazaContext.SaveChanges();
                return true;
            }
            catch (FaultException e)
            {
                throw new FaultException("Komentowanie tego przepisu nie powidło się.");
            }
        }//done
        /// <summary>
        /// Rejestracja użutkownika po sprawdzeniu e-maila
        /// </summary>
        /// <param name="imie">nie może być null</param>
        /// <param name="nazwisko">nie może być null</param>
        /// <param name="login">nie może być null</param>
        /// <param name="haslo">nie może być null</param>
        /// <param name="mail">nie może być null</param>
        /// <returns>rezultat sukces lub niepowodzenie</returns>
        public bool Rejestracja(string imie, string nazwisko, string login, string haslo, string mail)
        {
            try
            {
                Uzytkownik uzytkownik = new Uzytkownik { Login = login, Haslo = haslo, Imie = imie, Nazwisko = nazwisko, Email = mail, SuperUser = false };
                bazaContext.setUzytkownicy.Add(uzytkownik);
                bazaContext.SaveChanges();
                return true;
            }
            catch (FaultException e)
            {
                throw new FaultException("Operacja rejestracji nie powidła się.");
            }
        }//done
        /// <summary>
        /// Funkcja sprawdzenia poczty użytkownika
        /// </summary>
        /// <param name="mail">nie może być null</param>
        /// <returns>zwraca losową liczbe do interfejsu oraz dubluje ją na pocztę dla sprawdzenia</returns>
        public int SprawdzMail(string mail)
        {
            int liczba_losowa = 0;
            Random rnd = new Random();
            liczba_losowa = rnd.Next();

            string smtpServer = "smtp.mail.ru";
            string from = "fedorenko20081997@mail.ru";
            string password = "qwservetsqw";
            string mailto = mail;
            string caption = "Rejestracja w serwisie Twoja lodówka";
            string attachFile = null;
            string message = "Dla zakończenia rejestracji wpisz następny kod: " + liczba_losowa.ToString();
            try
            {
                MailMessage email = new MailMessage();
                email.From = new MailAddress(from);
                email.To.Add(new MailAddress(mailto));
                email.Subject = caption;
                email.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    email.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(email);
                email.Dispose();
                return liczba_losowa;
            }
            catch (FaultException e)
            {
                throw new FaultException("Wysyłanie kodu na e-mail nie powidło się.");
            }
        }//done
        /// <summary>
        /// szuka przepis za podaną przez użytkownika niecałą nazwą
        /// </summary>
        /// <param name="nazwa">część nazwy przepisu</param>
        /// <returns>zwraca całą nazwe przepisu</returns>
        public string SzukajDaniePoNazwie(string nazwa)
        {
            try
            {
                List<Przepis> przepisy = bazaContext.setPrzepisy.Where(p => p.Nazwa == nazwa).ToList();
                StringBuilder sb = new StringBuilder();
                foreach (Przepis p in przepisy)
                {
                    sb.AppendLine(p.Nazwa + " " + p.Popularnosc);
                }
                return sb.ToString();
            }
            catch (FaultException e)
            {
                return string.Format("Nie znaleziono.");
            }
        }
        /// <summary>
        /// Wyświetla 5 najpopularniejszych dań
        /// </summary>
        /// <returns>Lista z 5-u dań</returns>
        public string Top5Dan()
        {
            return string.Format("jakas dic");
        }//ojoj done

        public bool UsunZlodowki(int id_uzytkow, int id_lodowki, List<int> id_prod, List<int> ilosci)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sprawdza login żeby w bazie nie było powtórzeń
        /// </summary>
        /// <param name="login">login</param>
        /// <returns>jest albo niema</returns>
        public bool UzytkownikIstieje(string login)
        {
            Uzytkownik uzytkownik = bazaContext.setUzytkownicy.Where(u => u.Login == login).FirstOrDefault();
            if (uzytkownik != null)
                return true;
            else return false;
        }//done

        public UzytkownikDane WypiszDaneUzytkownika(int id, string login, string nazwisko)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// wypisuje komentarze do danego przepisu
        /// </summary>
        /// <param name="id_przepisu">numer przepisu</param>
        /// <returns>lista komentarzy</returns>
        public string WypiszKomentarze(int id_przepisu)
        {
            try
            {
                List<Komentarz> komentar = bazaContext.setKomentarze.Where(k => k.PrzepisID == id_przepisu).ToList();
                StringBuilder sb = new StringBuilder();
                foreach (Komentarz k in komentar)
                {
                    sb.AppendLine(k.Koment);
                }
                return sb.ToString();
            }
            catch (FaultException e)
            {
                throw new FaultException("Niema komentów");
            }

        }//done
        /// <summary>
        /// wypisuje zawartość lodówki użytkownika
        /// </summary>
        /// <param name="id_uzytkownika">uzytkownik</param>
        /// <returns>zwraca listę produktów i ich ilość na stanie</returns>
        public string WypiszLodowke(int id_uzytkownika)
        {
            try
            {
                Lodoweczka lodoweczka = bazaContext.setLodowki.Where(l => l.UzytkownikID == id_uzytkownika).SingleOrDefault();
                StringBuilder sb = new StringBuilder();
                string s = "";
                int iter = 0;

                int[] produktySpis = new int[50];
                int[] ilosciSpis = new int[50];
                string spisIdProd = lodoweczka.SpisIdProduktow;
                string spisWarto = lodoweczka.SpisIlosciProduktow;

                char[] spisArray = new char[spisIdProd.Length];
                spisArray = spisIdProd.ToCharArray();
                char[] arraySpis = new char[spisWarto.Length];
                arraySpis = spisWarto.ToCharArray();
                char znak = ',';

                for (int ch = 0; ch < spisArray.Length; ch++)
                {
                    if (spisArray[ch] != znak)
                        s = s + spisArray[ch].ToString();
                    //s = s + Int32.Parse(spisArray[ch].ToString());
                    else
                    {
                        produktySpis[iter] = Int32.Parse(s);
                        iter++;
                        s = "";
                    }
                }

                s = "";
                iter = 0;

                for (int cha = 0; cha < arraySpis.Length; cha++)
                {
                    if (arraySpis[cha] != ',')
                        s += arraySpis[cha].ToString();
                    else
                    {
                        ilosciSpis[iter] = Int32.Parse(s);
                        iter++;
                        s = "";
                    }
                }
                //sparsyty id produktiw

                //sparsyty kilkosti produktiw
                for (int i = 0; i < 50; i++)
                {
                    if (produktySpis[i] > 0)
                    {
                        int iii = produktySpis[i];
                        Produkt produkt = bazaContext.setProdukty.Where(p => p.Id == iii).SingleOrDefault();
                        sb.AppendLine(produkt.Nazwa + " " + ilosciSpis[i] + "g");
                    }
                }
                return sb.ToString();
            }
            catch (FaultException e)
            {
                throw new Exception("Sprawdzenie stanu lodowki jest niemożliwe");
            }
        }//done

        public PrzepisDane WypiszPrzepis(int id_przep)
        {
            //try
            //{
            //    Przepis przepis = bazaContext.setPrzepisy.Where(p => p.Id == id_przep).SingleOrDefault();
            //    string[] prod;
            //    int[] ilosci;

            //    PrzepisDane dane = new PrzepisDane();
                

            //}
            //catch (FaultException e)
            //{
            //    throw new FaultException("Niemam takiego");
            //}
            throw new NotImplementedException();
        }
        /// <summary>
        /// Nadać lub zabrać prawo administratora
        /// </summary>
        /// <param name="id_admin">administrator</param>
        /// <param name="id_uzytko">osoba</param>
        /// <param name="supeUzer">jaki ma mieć status</param>
        /// <returns>zwraca rezultat sukcesu tak lub nie</returns>
        public bool ZmienPrawoAdministratora(int id_admin, int id_uzytko, bool supeUzer)
        {
            try
            {
                Uzytkownik super = bazaContext.setUzytkownicy.Where(sup => sup.Id == id_admin).SingleOrDefault();
                if (super.SuperUser == true)
                {
                    Uzytkownik uzy = bazaContext.setUzytkownicy.Where(sup => sup.Id == id_uzytko).SingleOrDefault();
                    uzy.SuperUser = supeUzer;
                    bazaContext.SaveChanges();
                    return true;
                }
                else return false;
            }
            catch (FaultException e)
            {
                throw new FaultException("nie jest to możliwe!");
            }
            //throw new NotImplementedException();
        }
    }
}
