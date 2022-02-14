using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class KDKategoriDal : IKDKategoriDal
    {
        public List<KDKategori> Ara(int id)
        {
            throw new NotImplementedException();
        }

        public List<KDKategori> Ara(string ad)
        {
            IkysEntities context = new IkysEntities();
            return context.KDKategori.Where(p => p.KDKAdi == ad).ToList();
        }
        public KDKategori KategoriAra(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.KDKategori.Where(p => p.KDKId == id).FirstOrDefault();
        }
        public List<KDKategori> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.KDKategori.ToList();
        }

        public void Ekle(KDKategori kDKategori)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.KDKategori.Add(kDKategori);
            ekle.SaveChanges();
        }

        public void Guncelle(int id, string kategoriadi)
        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.KDKategori.Where(p => p.KDKId == id).FirstOrDefault();
            bul.KDKAdi = kategoriadi;
            guncelle.SaveChanges();
        }
        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.KDKategori.Where(p => p.KDKId == id).FirstOrDefault();
            sil.KDKategori.Remove(bul);
            sil.SaveChanges();
        }
    }
}
