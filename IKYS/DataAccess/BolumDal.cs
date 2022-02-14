using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class BolumDal : IBolumDal
    {
        public List<Bolum> Ara(int id)
        {
            
            IkysEntities context = new IkysEntities();
            
            return context.Bolum.Where(p => p.BolumId == id).ToList();
        }
        public Bolum BolumAdiGetir(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Bolum.Where(p => p.BolumId == id).FirstOrDefault();
        }

        public List<Bolum> Ara(string ad)
        {
            IkysEntities context = new IkysEntities();
            return context.Bolum.Where(p => p.BolumAdi == ad).ToList();
        }

        public List<Bolum> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.Bolum.ToList();
        }

        public void Ekle(Bolum bolum)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.Bolum.Add(bolum);
            ekle.SaveChanges();
        }

        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.Bolum.Where(p => p.BolumId == id).FirstOrDefault();
            sil.Bolum.Remove(bul);
            sil.SaveChanges();
            
        }

        public void Guncelle(int id, string bolumadi)
        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.Bolum.Where(p => p.BolumId == id).FirstOrDefault();
            bul.BolumAdi = bolumadi;

            guncelle.SaveChanges();
        }
    }
}
