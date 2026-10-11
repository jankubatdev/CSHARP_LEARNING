using System;

namespace Pojazd
{
    internal class Program
    {
        public class Pojazd
        {


            private string _marka;
            private int _rokProdukcji;
            

            public string Marka
            {
                get
                {
                    return _marka;
                }
                private set { _marka = value; }
            }

            public int RokProdukcji
            {
                get
                {
                    return _rokProdukcji;

                }
                private set { _rokProdukcji = value; }
            }
            public Pojazd(string marka, int rokProdukcji)
            {
                this.Marka = marka;
                this.RokProdukcji = rokProdukcji;
            }
            public virtual void PojazdInfo()
            {
                Console.WriteLine("Oryginalna");
                Console.WriteLine($"Marka pojazdu: {Marka}");
                Console.WriteLine($"Rok produkcji: {RokProdukcji}");
                Console.WriteLine();

            }


        }
        public class Samochod : Pojazd
        {
            private int _iloscDrzwi;
            private string _rodzajPaliwa;
            private int _radio;
            

            public int iloscDrzwi{ get { return _iloscDrzwi; } private set {_iloscDrzwi = value;} }
            public string rodzajPaliwa { get { return _rodzajPaliwa; }private set { _rodzajPaliwa = value;}}
            public int radio { get { return _radio; }private set { _radio = value;}}

            public Samochod(string marka, int rokProdukcji, int iloscDrzwi, string rodzajPaliwa, int radio):base(marka,rokProdukcji)
            {
                this.iloscDrzwi = iloscDrzwi;
                this.rodzajPaliwa = rodzajPaliwa;
                this.radio = radio;

            }
        public override void PojazdInfo()
            {
                
                base.PojazdInfo();
                Console.WriteLine("Metoda 1 dziedzicząca");
                Console.WriteLine($"Ilosc drzwi {iloscDrzwi}");
                Console.WriteLine($"rodzaj paliwa {rodzajPaliwa}");
                Console.WriteLine($"Czy ma Pajonier {radio}");
                Console.WriteLine();
                

            }

        }
        public class SamochodElektryczny : Samochod
        {
            private string _silnikElektryczny;
            public string silnikElektryczny
            {
                get
                { return _silnikElektryczny; }


                private set
                { _silnikElektryczny = value; }

            }
            public SamochodElektryczny(string silnikElektryczny, string marka, int rokProdukcji, int iloscDrzwi, string rodzajPaliwa, int radio) :base( marka,  rokProdukcji, iloscDrzwi, rodzajPaliwa, radio)
            {
                this.silnikElektryczny = silnikElektryczny;
            }

            public override void PojazdInfo()
            {
                
                base.PojazdInfo();
                Console.WriteLine("Druga dziedziczaca");
                Console.WriteLine($"Ma silnik elektryczny? {silnikElektryczny}");

                
            }




        }

        static void Main(string[] args)
        {
            
            Samochod samochod1 = new Samochod("Audi", 1999, 5, "BENZINE", 1);
            SamochodElektryczny elektryk = new SamochodElektryczny("POSIADA", "Izera", 2030, 5, "ELEKTRIC", 1);
            List<Pojazd> pojazdy = new List<Pojazd>();
            List<Samochod> samochody = new List<Samochod>();
            List<SamochodElektryczny> Elektryki = new List<SamochodElektryczny>();
            pojazdy.Add(samochod1);
            pojazdy.Add(elektryk);
            foreach (Pojazd pojazd in pojazdy)
            {
                pojazd.PojazdInfo();
            }
            


           

        }
    }
}
