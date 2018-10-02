using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LodowkaSerwice
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IService1
    {
        //
        //====================== 1 - operacje logowania się =====================
        //    
        [FaultContract(typeof(string))]
        [OperationContract]
        int Logowanie_zapasowe(string login, string haslo);  //logowanie, użyć jezeli inne nie działa        

        [FaultContract(typeof(string))]
        [OperationContract]
        SuperUzytkownikType Logowanie(string login, string haslo); //zwraca id zalogowanego użytkownika i status superużytkownika
        //
        //======================= 2 - operacje rejestrowania się ======================
        //
        [FaultContract(typeof(string))]
        [OperationContract]
        bool Rejestracja(string imie, string nazwisko, string login, string haslo, string mail);    //rejestruje nowego użytkownika

        [FaultContract(typeof(string))]
        [OperationContract]
        int SprawdzMail(string mail); //wysyła na mail losową liczbę dla sprawdzenia maila

        [FaultContract(typeof(string))]
        [OperationContract]
        bool UzytkownikIstieje(string login); //sprawdza czy jest taki uzytkownik
        //
        //======================= 3 - Przepisy ======================
        //
        [FaultContract(typeof(string))]
        [OperationContract]
        string WypiszKomentarze(int id_przepisu);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool NapiszKomentarz(int id_uzytkownika, int id_przepisu, string komentarz);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool LajknijPrzepis(int id_uzutkownika, int id_przepisu);

        [FaultContract(typeof(string))]
        [OperationContract]
        string Top5Dan();

        [FaultContract(typeof(string))]
        [OperationContract]
        string SzukajDaniePoNazwie(string nazwa);

        [FaultContract(typeof(string))]
        [OperationContract]
        PrzepisDane WypiszPrzepis(int id_przep);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool dodajNowyPrzepis(string nazwa, string opis, List<int> id_produktow, List<int> ilosci_produktow);
        //
        //===================== 4 - Lodowka =========================
        //
        [FaultContract(typeof(string))]
        [OperationContract]
        string WypiszLodowke(int id_uzytkownika);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool DodajProdDoLodowki(int id_uzytkow, int id_lodowki, List<int> id_prod, List<int> ilosci);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool UsunZlodowki(int id_uzytkow, int id_lodowki, List<int> id_prod, List<int> ilosci);
        //
        //=================== 5 - Prawa administratora =====================
        //
        [FaultContract(typeof(string))]
        [OperationContract]
        List<PrzepisDaneAdmin> AdminWypiszNiezatwPrzepisy();

        [FaultContract(typeof(string))]
        [OperationContract]
        bool AdminZatwierdzPrzepis(int id_admin, int id_przepis, bool zatwierdz);

        [FaultContract(typeof(string))]
        [OperationContract]
        bool ZmienPrawoAdministratora(int id_admin, int id_uzytko, bool supeUzer);

        [FaultContract(typeof(string))]
        [OperationContract]
        UzytkownikDane WypiszDaneUzytkownika(int id, string login, string nazwisko);

        // TODO: dodaj tutaj operacje usługi
    }

    [DataContract]
    public class UzytkownikDane
    {
        int id = 0;
        string imie = "";
        string nazwisko = "";
        string login = "";
        string email = "";
        bool super = false;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Imie
        {
            get
            {
                return imie;
            }

            set
            {
                imie = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }

            set
            {
                nazwisko = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public bool Super
        {
            get
            {
                return super;
            }

            set
            {
                super = value;
            }
        }
    }

    [DataContract]
    public class PrzepisDaneAdmin
    {
        int id = 0;
        string nazwa = "";
        string opis = "";
        string spisProd = "";
        string ilosciProd = "";

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string SpisProd
        {
            get
            {
                return spisProd;
            }

            set
            {
                spisProd = value;
            }
        }

        public string IlosciProd
        {
            get
            {
                return ilosciProd;
            }

            set
            {
                ilosciProd = value;
            }
        }
    }

    [DataContract]
    public class PrzepisDane
    {
        int id = 0;
        string nazwa = "";
        string opis = "";
        string spisProd = "";
        string ilosciProd = "";
        double popularnosc = 0;

        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string SpisProd
        {
            get
            {
                return spisProd;
            }

            set
            {
                spisProd = value;
            }
        }

        public string IlosciProd
        {
            get
            {
                return ilosciProd;
            }

            set
            {
                ilosciProd = value;
            }
        }

        public double Popularnosc
        {
            get
            {
                return popularnosc;
            }

            set
            {
                popularnosc = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }

    [DataContract]
    public class SuperUzytkownikType
    {
        int id_super = 0;
        bool status_super = false;

        [DataMember]
        public int Id_super
        {
            get { return id_super; }
            set { id_super = value; }
        }

        [DataMember]
        public bool Status_super
        {
            get { return status_super; }
            set { status_super = value; }
        }
    }
    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
}
