﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwojaLodowka.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SuperUzytkownikType", Namespace="http://schemas.datacontract.org/2004/07/LodowkaSerwice")]
    [System.SerializableAttribute()]
    public partial class SuperUzytkownikType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_superField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Status_superField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_super {
            get {
                return this.Id_superField;
            }
            set {
                if ((this.Id_superField.Equals(value) != true)) {
                    this.Id_superField = value;
                    this.RaisePropertyChanged("Id_super");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status_super {
            get {
                return this.Status_superField;
            }
            set {
                if ((this.Status_superField.Equals(value) != true)) {
                    this.Status_superField = value;
                    this.RaisePropertyChanged("Status_super");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PrzepisDane", Namespace="http://schemas.datacontract.org/2004/07/LodowkaSerwice")]
    [System.SerializableAttribute()]
    public partial class PrzepisDane : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Przepis", Namespace="http://schemas.datacontract.org/2004/07/LodowkaSerwice.Models")]
    [System.SerializableAttribute()]
    public partial class Przepis : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ilosci_produktowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PopularnoscField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Spis_produktowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ZatwierdzonyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ilosci_produktow {
            get {
                return this.Ilosci_produktowField;
            }
            set {
                if ((object.ReferenceEquals(this.Ilosci_produktowField, value) != true)) {
                    this.Ilosci_produktowField = value;
                    this.RaisePropertyChanged("Ilosci_produktow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwa {
            get {
                return this.NazwaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwaField, value) != true)) {
                    this.NazwaField = value;
                    this.RaisePropertyChanged("Nazwa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opis {
            get {
                return this.OpisField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisField, value) != true)) {
                    this.OpisField = value;
                    this.RaisePropertyChanged("Opis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Popularnosc {
            get {
                return this.PopularnoscField;
            }
            set {
                if ((this.PopularnoscField.Equals(value) != true)) {
                    this.PopularnoscField = value;
                    this.RaisePropertyChanged("Popularnosc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Spis_produktow {
            get {
                return this.Spis_produktowField;
            }
            set {
                if ((object.ReferenceEquals(this.Spis_produktowField, value) != true)) {
                    this.Spis_produktowField = value;
                    this.RaisePropertyChanged("Spis_produktow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Zatwierdzony {
            get {
                return this.ZatwierdzonyField;
            }
            set {
                if ((this.ZatwierdzonyField.Equals(value) != true)) {
                    this.ZatwierdzonyField = value;
                    this.RaisePropertyChanged("Zatwierdzony");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UzytkownikDane", Namespace="http://schemas.datacontract.org/2004/07/LodowkaSerwice")]
    [System.SerializableAttribute()]
    public partial class UzytkownikDane : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logowanie_zapasowe", ReplyAction="http://tempuri.org/IService1/Logowanie_zapasoweResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/Logowanie_zapasoweStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        int Logowanie_zapasowe(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logowanie_zapasowe", ReplyAction="http://tempuri.org/IService1/Logowanie_zapasoweResponse")]
        System.Threading.Tasks.Task<int> Logowanie_zapasoweAsync(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logowanie", ReplyAction="http://tempuri.org/IService1/LogowanieResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/LogowanieStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        TwojaLodowka.ServiceReference3.SuperUzytkownikType Logowanie(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Logowanie", ReplyAction="http://tempuri.org/IService1/LogowanieResponse")]
        System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.SuperUzytkownikType> LogowanieAsync(string login, string haslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rejestracja", ReplyAction="http://tempuri.org/IService1/RejestracjaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/RejestracjaStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool Rejestracja(string imie, string nazwisko, string login, string haslo, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Rejestracja", ReplyAction="http://tempuri.org/IService1/RejestracjaResponse")]
        System.Threading.Tasks.Task<bool> RejestracjaAsync(string imie, string nazwisko, string login, string haslo, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SprawdzMail", ReplyAction="http://tempuri.org/IService1/SprawdzMailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/SprawdzMailStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        int SprawdzMail(string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SprawdzMail", ReplyAction="http://tempuri.org/IService1/SprawdzMailResponse")]
        System.Threading.Tasks.Task<int> SprawdzMailAsync(string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UzytkownikIstieje", ReplyAction="http://tempuri.org/IService1/UzytkownikIstiejeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/UzytkownikIstiejeStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool UzytkownikIstieje(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UzytkownikIstieje", ReplyAction="http://tempuri.org/IService1/UzytkownikIstiejeResponse")]
        System.Threading.Tasks.Task<bool> UzytkownikIstiejeAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszKomentarze", ReplyAction="http://tempuri.org/IService1/WypiszKomentarzeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/WypiszKomentarzeStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        string WypiszKomentarze(int id_przepisu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszKomentarze", ReplyAction="http://tempuri.org/IService1/WypiszKomentarzeResponse")]
        System.Threading.Tasks.Task<string> WypiszKomentarzeAsync(int id_przepisu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NapiszKomentarz", ReplyAction="http://tempuri.org/IService1/NapiszKomentarzResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/NapiszKomentarzStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool NapiszKomentarz(int id_uzytkownika, int id_przepisu, string komentarz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NapiszKomentarz", ReplyAction="http://tempuri.org/IService1/NapiszKomentarzResponse")]
        System.Threading.Tasks.Task<bool> NapiszKomentarzAsync(int id_uzytkownika, int id_przepisu, string komentarz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LajknijPrzepis", ReplyAction="http://tempuri.org/IService1/LajknijPrzepisResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/LajknijPrzepisStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool LajknijPrzepis(int id_uzutkownika, int id_przepisu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LajknijPrzepis", ReplyAction="http://tempuri.org/IService1/LajknijPrzepisResponse")]
        System.Threading.Tasks.Task<bool> LajknijPrzepisAsync(int id_uzutkownika, int id_przepisu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top5Dan", ReplyAction="http://tempuri.org/IService1/Top5DanResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/Top5DanStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        string Top5Dan();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top5Dan", ReplyAction="http://tempuri.org/IService1/Top5DanResponse")]
        System.Threading.Tasks.Task<string> Top5DanAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SzukajDaniePoNazwie", ReplyAction="http://tempuri.org/IService1/SzukajDaniePoNazwieResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/SzukajDaniePoNazwieStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        string SzukajDaniePoNazwie(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SzukajDaniePoNazwie", ReplyAction="http://tempuri.org/IService1/SzukajDaniePoNazwieResponse")]
        System.Threading.Tasks.Task<string> SzukajDaniePoNazwieAsync(string nazwa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszPrzepis", ReplyAction="http://tempuri.org/IService1/WypiszPrzepisResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/WypiszPrzepisStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        TwojaLodowka.ServiceReference3.PrzepisDane WypiszPrzepis(int id_przep);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszPrzepis", ReplyAction="http://tempuri.org/IService1/WypiszPrzepisResponse")]
        System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.PrzepisDane> WypiszPrzepisAsync(int id_przep);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/dodajNowyPrzepis", ReplyAction="http://tempuri.org/IService1/dodajNowyPrzepisResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/dodajNowyPrzepisStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool dodajNowyPrzepis(string nazwa, string opis, string id_produktow, string ilosci_produktow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/dodajNowyPrzepis", ReplyAction="http://tempuri.org/IService1/dodajNowyPrzepisResponse")]
        System.Threading.Tasks.Task<bool> dodajNowyPrzepisAsync(string nazwa, string opis, string id_produktow, string ilosci_produktow);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszLodowke", ReplyAction="http://tempuri.org/IService1/WypiszLodowkeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/WypiszLodowkeStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        string WypiszLodowke(int id_uzytkownika);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszLodowke", ReplyAction="http://tempuri.org/IService1/WypiszLodowkeResponse")]
        System.Threading.Tasks.Task<string> WypiszLodowkeAsync(int id_uzytkownika);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajProdDoLodowki", ReplyAction="http://tempuri.org/IService1/DodajProdDoLodowkiResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/DodajProdDoLodowkiStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool DodajProdDoLodowki(int id_uzytkow, int id_prod, int ilosci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DodajProdDoLodowki", ReplyAction="http://tempuri.org/IService1/DodajProdDoLodowkiResponse")]
        System.Threading.Tasks.Task<bool> DodajProdDoLodowkiAsync(int id_uzytkow, int id_prod, int ilosci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunZlodowki", ReplyAction="http://tempuri.org/IService1/UsunZlodowkiResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/UsunZlodowkiStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool UsunZlodowki(int id_uzytkow, int id_prod, int ilosci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UsunZlodowki", ReplyAction="http://tempuri.org/IService1/UsunZlodowkiResponse")]
        System.Threading.Tasks.Task<bool> UsunZlodowkiAsync(int id_uzytkow, int id_prod, int ilosci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AdminWypiszNiezatwPrzepisy", ReplyAction="http://tempuri.org/IService1/AdminWypiszNiezatwPrzepisyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/AdminWypiszNiezatwPrzepisyStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        TwojaLodowka.ServiceReference3.Przepis[] AdminWypiszNiezatwPrzepisy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AdminWypiszNiezatwPrzepisy", ReplyAction="http://tempuri.org/IService1/AdminWypiszNiezatwPrzepisyResponse")]
        System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.Przepis[]> AdminWypiszNiezatwPrzepisyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AdminZatwierdzPrzepis", ReplyAction="http://tempuri.org/IService1/AdminZatwierdzPrzepisResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/AdminZatwierdzPrzepisStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool AdminZatwierdzPrzepis(int id_admin, int id_przepis, bool zatwierdz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AdminZatwierdzPrzepis", ReplyAction="http://tempuri.org/IService1/AdminZatwierdzPrzepisResponse")]
        System.Threading.Tasks.Task<bool> AdminZatwierdzPrzepisAsync(int id_admin, int id_przepis, bool zatwierdz);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ZmienPrawoAdministratora", ReplyAction="http://tempuri.org/IService1/ZmienPrawoAdministratoraResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/ZmienPrawoAdministratoraStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        bool ZmienPrawoAdministratora(int id_admin, int id_uzytko, bool supeUzer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ZmienPrawoAdministratora", ReplyAction="http://tempuri.org/IService1/ZmienPrawoAdministratoraResponse")]
        System.Threading.Tasks.Task<bool> ZmienPrawoAdministratoraAsync(int id_admin, int id_uzytko, bool supeUzer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszDaneUzytkownika", ReplyAction="http://tempuri.org/IService1/WypiszDaneUzytkownikaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IService1/WypiszDaneUzytkownikaStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        TwojaLodowka.ServiceReference3.UzytkownikDane WypiszDaneUzytkownika(int id, string login, string nazwisko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WypiszDaneUzytkownika", ReplyAction="http://tempuri.org/IService1/WypiszDaneUzytkownikaResponse")]
        System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.UzytkownikDane> WypiszDaneUzytkownikaAsync(int id, string login, string nazwisko);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TwojaLodowka.ServiceReference3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TwojaLodowka.ServiceReference3.IService1>, TwojaLodowka.ServiceReference3.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Logowanie_zapasowe(string login, string haslo) {
            return base.Channel.Logowanie_zapasowe(login, haslo);
        }
        
        public System.Threading.Tasks.Task<int> Logowanie_zapasoweAsync(string login, string haslo) {
            return base.Channel.Logowanie_zapasoweAsync(login, haslo);
        }
        
        public TwojaLodowka.ServiceReference3.SuperUzytkownikType Logowanie(string login, string haslo) {
            return base.Channel.Logowanie(login, haslo);
        }
        
        public System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.SuperUzytkownikType> LogowanieAsync(string login, string haslo) {
            return base.Channel.LogowanieAsync(login, haslo);
        }
        
        public bool Rejestracja(string imie, string nazwisko, string login, string haslo, string mail) {
            return base.Channel.Rejestracja(imie, nazwisko, login, haslo, mail);
        }
        
        public System.Threading.Tasks.Task<bool> RejestracjaAsync(string imie, string nazwisko, string login, string haslo, string mail) {
            return base.Channel.RejestracjaAsync(imie, nazwisko, login, haslo, mail);
        }
        
        public int SprawdzMail(string mail) {
            return base.Channel.SprawdzMail(mail);
        }
        
        public System.Threading.Tasks.Task<int> SprawdzMailAsync(string mail) {
            return base.Channel.SprawdzMailAsync(mail);
        }
        
        public bool UzytkownikIstieje(string login) {
            return base.Channel.UzytkownikIstieje(login);
        }
        
        public System.Threading.Tasks.Task<bool> UzytkownikIstiejeAsync(string login) {
            return base.Channel.UzytkownikIstiejeAsync(login);
        }
        
        public string WypiszKomentarze(int id_przepisu) {
            return base.Channel.WypiszKomentarze(id_przepisu);
        }
        
        public System.Threading.Tasks.Task<string> WypiszKomentarzeAsync(int id_przepisu) {
            return base.Channel.WypiszKomentarzeAsync(id_przepisu);
        }
        
        public bool NapiszKomentarz(int id_uzytkownika, int id_przepisu, string komentarz) {
            return base.Channel.NapiszKomentarz(id_uzytkownika, id_przepisu, komentarz);
        }
        
        public System.Threading.Tasks.Task<bool> NapiszKomentarzAsync(int id_uzytkownika, int id_przepisu, string komentarz) {
            return base.Channel.NapiszKomentarzAsync(id_uzytkownika, id_przepisu, komentarz);
        }
        
        public bool LajknijPrzepis(int id_uzutkownika, int id_przepisu) {
            return base.Channel.LajknijPrzepis(id_uzutkownika, id_przepisu);
        }
        
        public System.Threading.Tasks.Task<bool> LajknijPrzepisAsync(int id_uzutkownika, int id_przepisu) {
            return base.Channel.LajknijPrzepisAsync(id_uzutkownika, id_przepisu);
        }
        
        public string Top5Dan() {
            return base.Channel.Top5Dan();
        }
        
        public System.Threading.Tasks.Task<string> Top5DanAsync() {
            return base.Channel.Top5DanAsync();
        }
        
        public string SzukajDaniePoNazwie(string nazwa) {
            return base.Channel.SzukajDaniePoNazwie(nazwa);
        }
        
        public System.Threading.Tasks.Task<string> SzukajDaniePoNazwieAsync(string nazwa) {
            return base.Channel.SzukajDaniePoNazwieAsync(nazwa);
        }
        
        public TwojaLodowka.ServiceReference3.PrzepisDane WypiszPrzepis(int id_przep) {
            return base.Channel.WypiszPrzepis(id_przep);
        }
        
        public System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.PrzepisDane> WypiszPrzepisAsync(int id_przep) {
            return base.Channel.WypiszPrzepisAsync(id_przep);
        }
        
        public bool dodajNowyPrzepis(string nazwa, string opis, string id_produktow, string ilosci_produktow) {
            return base.Channel.dodajNowyPrzepis(nazwa, opis, id_produktow, ilosci_produktow);
        }
        
        public System.Threading.Tasks.Task<bool> dodajNowyPrzepisAsync(string nazwa, string opis, string id_produktow, string ilosci_produktow) {
            return base.Channel.dodajNowyPrzepisAsync(nazwa, opis, id_produktow, ilosci_produktow);
        }
        
        public string WypiszLodowke(int id_uzytkownika) {
            return base.Channel.WypiszLodowke(id_uzytkownika);
        }
        
        public System.Threading.Tasks.Task<string> WypiszLodowkeAsync(int id_uzytkownika) {
            return base.Channel.WypiszLodowkeAsync(id_uzytkownika);
        }
        
        public bool DodajProdDoLodowki(int id_uzytkow, int id_prod, int ilosci) {
            return base.Channel.DodajProdDoLodowki(id_uzytkow, id_prod, ilosci);
        }
        
        public System.Threading.Tasks.Task<bool> DodajProdDoLodowkiAsync(int id_uzytkow, int id_prod, int ilosci) {
            return base.Channel.DodajProdDoLodowkiAsync(id_uzytkow, id_prod, ilosci);
        }
        
        public bool UsunZlodowki(int id_uzytkow, int id_prod, int ilosci) {
            return base.Channel.UsunZlodowki(id_uzytkow, id_prod, ilosci);
        }
        
        public System.Threading.Tasks.Task<bool> UsunZlodowkiAsync(int id_uzytkow, int id_prod, int ilosci) {
            return base.Channel.UsunZlodowkiAsync(id_uzytkow, id_prod, ilosci);
        }
        
        public TwojaLodowka.ServiceReference3.Przepis[] AdminWypiszNiezatwPrzepisy() {
            return base.Channel.AdminWypiszNiezatwPrzepisy();
        }
        
        public System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.Przepis[]> AdminWypiszNiezatwPrzepisyAsync() {
            return base.Channel.AdminWypiszNiezatwPrzepisyAsync();
        }
        
        public bool AdminZatwierdzPrzepis(int id_admin, int id_przepis, bool zatwierdz) {
            return base.Channel.AdminZatwierdzPrzepis(id_admin, id_przepis, zatwierdz);
        }
        
        public System.Threading.Tasks.Task<bool> AdminZatwierdzPrzepisAsync(int id_admin, int id_przepis, bool zatwierdz) {
            return base.Channel.AdminZatwierdzPrzepisAsync(id_admin, id_przepis, zatwierdz);
        }
        
        public bool ZmienPrawoAdministratora(int id_admin, int id_uzytko, bool supeUzer) {
            return base.Channel.ZmienPrawoAdministratora(id_admin, id_uzytko, supeUzer);
        }
        
        public System.Threading.Tasks.Task<bool> ZmienPrawoAdministratoraAsync(int id_admin, int id_uzytko, bool supeUzer) {
            return base.Channel.ZmienPrawoAdministratoraAsync(id_admin, id_uzytko, supeUzer);
        }
        
        public TwojaLodowka.ServiceReference3.UzytkownikDane WypiszDaneUzytkownika(int id, string login, string nazwisko) {
            return base.Channel.WypiszDaneUzytkownika(id, login, nazwisko);
        }
        
        public System.Threading.Tasks.Task<TwojaLodowka.ServiceReference3.UzytkownikDane> WypiszDaneUzytkownikaAsync(int id, string login, string nazwisko) {
            return base.Channel.WypiszDaneUzytkownikaAsync(id, login, nazwisko);
        }
    }
}
