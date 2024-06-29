using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSalonu
{
    class Salon
    {
        private string _salonAdi;
        private int _koltukAdedi;
        private int _kasa=0;
        private int _tamBilet = 100;
        private int _indirimliBilet = 65;

        public string SalonAdi
        {
            get 
            { 
                return _salonAdi; 
            }   
            set 
            { 
                _salonAdi = value; 
            }
        }

        public int KoltukAdedi
        {
            get { return _koltukAdedi; }
            set 
            {
                if (value >= 20 && value <= 50)
                    _koltukAdedi = value;
                else
                    throw new Exception("Koltuk Adedi 20 ile 50 arasında olmalıdır.");
            }
        }
        public int Kasa 
        { 
            get 
            { 
                return _kasa; 
            } 
            set { _kasa = value; }
        }
        public int TamBilet { get { return _tamBilet; } }
        public int IndirimliBilet { get { return _indirimliBilet; } }

        // Yapıcı Metotlar
        public Salon()
        {

        }
        public Salon(string salonAdi)
        {
            SalonAdi = salonAdi;
            KoltukAdedi = 0;
        }
        public Salon(int koltukAdedi)
        {
            KoltukAdedi = koltukAdedi;
            SalonAdi = "";
        }
        public Salon(string salonAdi, int koltukAdedi)
        {
            SalonAdi=salonAdi;
            KoltukAdedi=koltukAdedi;
        }

        public bool satis(bool biletTipi)
        {
            if(KoltukAdedi>0)
            {
                if(biletTipi==true)
                {
                    Kasa += IndirimliBilet;
                    _koltukAdedi--;
                }
                if(biletTipi==false)
                {
                    Kasa += TamBilet;
                    _koltukAdedi--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
