using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace POP_52_2016_GUI.Model
{
    [Serializable]
    public class Namestaj : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set {
                id = value;
                OnPropertyChanged("Id");
                }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set {
                naziv = value;
                OnPropertyChanged("Naziv");
            }
        }

        private double jedinincnaCena;

        public double JedinicnaCena
        {
            get { return jedinincnaCena; }
            set {
                jedinincnaCena = value;
                OnPropertyChanged("JedinicnaCena");
                }
        }

        private int akcija;

        public int Akcija
        {
            get { return akcija; }
            set { akcija = value;
                OnPropertyChanged("Akcija");
                }
        }

        private int kolicina;

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value;
                OnPropertyChanged("Kolicina");
            }
        }

        private string sifra;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value;
                OnPropertyChanged("Sifra");
            }
        }

        private bool obrisan;

        public bool Obrisan
        {
            get { return obrisan; }
            set { obrisan = value;
                OnPropertyChanged("Obrisan");
            }
        }

        private string tipNamestaja;

        public string TipNamestaja
        {
            get { return tipNamestaja; }
            set { tipNamestaja = value;
                OnPropertyChanged("TipNamestaja");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            if (akcija != 0)
            {
                return $"Naziv: {naziv} | Cena: {JedinicnaCena} | tip namestaja: {TipNamestaja.GetID(tipNamestaja).Naziv} | Akcija: {Akcija.GetID(akcija).naziv}";
            }else
            {
                return $"Naziv: {naziv} | Cena: {JedinicnaCena} | tip namestaja: {TipNamestaja.GetId(tipNamestaja).Naziv}";
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
