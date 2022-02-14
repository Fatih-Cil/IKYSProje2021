using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class GorevDal : IGorevDal //üzerindeki tüm methodları implement etmem şart.
    {
        public List<Gorev> Ara(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Gorev.Where(p => p.GorevId == id).ToList();
        }
        public Gorev GorevAdiGetir(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Gorev.Where(p => p.GorevId == id).FirstOrDefault();
        }

        public List<Gorev> Ara(string ad)
        {
            IkysEntities context = new IkysEntities();
            return context.Gorev.Where(p => p.GorevAdi == ad).ToList();
        }

        public List<Gorev> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.Gorev.OrderBy(p => p.GorevAdi).ToList();
        }

        public void Ekle(Gorev gorev)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.Gorev.Add(gorev);
            ekle.SaveChanges();
        }

        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul=sil.Gorev.Where(p => p.GorevId == id).FirstOrDefault();
            sil.Gorev.Remove(bul);
            sil.SaveChanges();
        }

        public void Guncelle(int id,string gorevadi)
        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.Gorev.Where(p => p.GorevId == id).FirstOrDefault();
            bul.GorevAdi = gorevadi;
            guncelle.SaveChanges();
        }
    }
}
