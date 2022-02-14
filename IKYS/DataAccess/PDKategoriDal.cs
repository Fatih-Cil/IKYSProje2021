using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class PDKategoriDal : IPDKategoriDal
    {
        public List<PDKategori> Ara(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.PDKategori.Where(p => p.PDKId == id).ToList();
        }

        public PDKategori KategoriAra(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.PDKategori.Where(p => p.PDKId == id).FirstOrDefault();
        }
        public List<PDKategori> Ara(string ad)
        {
            IkysEntities context = new IkysEntities();
            return context.PDKategori.Where(p => p.PDKAdi == ad).ToList();
        }

        public List<PDKategori> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.PDKategori.ToList();
        }
        public void Ekle(PDKategori pDKategori)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.PDKategori.Add(pDKategori);
            ekle.SaveChanges();
        }
        public void Guncelle(int id, string kategoriadi)
        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.PDKategori.Where(p => p.PDKId == id).FirstOrDefault();
            bul.PDKAdi = kategoriadi;

            guncelle.SaveChanges();
        }
        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.PDKategori.Where(p => p.PDKId == id).FirstOrDefault();
            sil.PDKategori.Remove(bul);
            sil.SaveChanges();
        }
    }
}
