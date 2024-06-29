using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunStok
{
    internal class Urun
    {
        private int _urunkodu;
        private string _urunadi;
        private object _urunkategori;
        private int _stokmiktari;

        public Urun() { }

        public Urun(int urunkodu, string urunadi, object urunkategori, int stokmiktari)
        {
            _urunkodu = urunkodu;
            _urunadi = urunadi;
            _urunkategori = urunkategori;
            _stokmiktari = stokmiktari;
        }

        public int UrunKodu { get { return _urunkodu; } set { _urunkodu = value; } }
        public string UrunAdi { get { return _urunadi; } set { _urunadi = value; } }
        public object UrunKategori { get { return _urunkategori; } set { _urunkategori = value; } }
        public int StokMiktari { get { return _stokmiktari; } set { _stokmiktari = value; } }        
    }
}
