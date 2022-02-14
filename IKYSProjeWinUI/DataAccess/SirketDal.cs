using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.DataAccess
{
    class SirketDal
    {
        public List<Sirket> SirketListele()
        {
            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Sirket.ToList();
        }
        public void SirketUpdate(int id, string unvan, string adres, string telefon,string vergiDairesiNo,string vergiDairesiAdi)
        {


            IKYSProjeEntities sirket = new IKYSProjeEntities();
            var guncelle = sirket.Sirket.Where(p => p.SirketId == id).FirstOrDefault();
            
            guncelle.VergiDairesiNo = vergiDairesiNo;
            guncelle.VergiDairesiAdi = vergiDairesiAdi;
            guncelle.Unvan = unvan;
            guncelle.Adres = adres;
            guncelle.Telefon = telefon;
            sirket.SaveChanges();

        }

        public int SirketAra(string deger)
        {
            IKYSProjeEntities sirket = new IKYSProjeEntities();
            var bul=sirket.Sirket.Where(p => p.VergiDairesiNo == deger).FirstOrDefault();

            if (bul.VergiDairesiNo == null )
            {
                return 1;
            }
            else return 0;
        }

        public void SirketEkle(Sirket sirket)
        {
            int bul=SirketAra(sirket.VergiDairesiNo);
            if (bul==0)
            {
                IKYSProjeEntities ekle = new IKYSProjeEntities();
                ekle.Sirket.Add(sirket);
                ekle.SaveChanges();
            }
            
            

        }
        public void SirketSil(int sirketId)
        {
            IKYSProjeEntities sil = new IKYSProjeEntities();
            var bul=sil.Sirket.Where(p => p.SirketId == sirketId).FirstOrDefault();
            sil.Sirket.Remove(bul);
            sil.SaveChanges();


        }
    }
}
