using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class SirketDal : ISirketDal
    {
        public List<Sirket> Ara(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Sirket.Where(p => p.SirketId == id).ToList();
        }
        public List<Sirket> Ara(string unvan)
        {
            IkysEntities context = new IkysEntities();
            return context.Sirket.Where(p => p.Unvan.Contains(unvan)).ToList();
        }

        public List<Sirket> TumunuListele()
        {
            IkysEntities context = new IkysEntities();

            return context.Sirket.ToList();
        }
        public string SirketAdiGetir(int id)
        {
            IkysEntities context = new IkysEntities();
            var deger = context.Sirket.Where(p => p.SirketId == id).FirstOrDefault();
            return deger.Unvan;

        }


        public void Guncelle(int id, string unvan, string telefon, string adres, string vdno, string vdadi)
        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.Sirket.Where(p => p.SirketId == id).FirstOrDefault();
            bul.Unvan = unvan;
            bul.Telefon = telefon;
            bul.Adres = adres;
            bul.VergiDairesiNo = vdno;
            bul.VergiDairesiAdi = vdadi;

            guncelle.SaveChanges();
        }
    }
}
