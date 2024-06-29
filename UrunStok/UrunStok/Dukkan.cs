using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    internal class Dukkan
    {
        List<Urun> uruns = new List<Urun>();
       public bool urunEkle(Urun urun)
       {
           bool kontrol = false;
            try
            {
                foreach (Urun item in uruns)
                {
                    if (item.UrunKodu == urun.UrunKodu)
                        kontrol = true;                  
                }
                if (kontrol)
                    return false;
                else
                {
                    uruns.Add(urun);
                    return true;
                }
            }
            catch (Exception)
            { return false; }
       } 
        
        public Urun urunAra(int urunkod)
        {
            foreach(Urun item in uruns)
            {
                if (item.UrunKodu == urunkod)
                    return item;
            }
            return null;
        }

        public bool urunSil(int urunkod)
        {
            foreach(Urun item in uruns)
            {
                if (item.UrunKodu == urunkod)
                {
                    uruns.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool urunDuzenle(Urun urun)
        {
            foreach(Urun item in uruns)
            {
                if(item.UrunKodu == urun.UrunKodu)
                {
                    item.UrunAdi = urun.UrunAdi;
                    item.UrunKategori = urun.UrunKategori;
                    item.StokMiktari = urun.StokMiktari;
                    return true;
                }
            }
            return false;
        }

        public List<Urun> urunleriGonder()
        {
            return uruns;
        }
    }
}
