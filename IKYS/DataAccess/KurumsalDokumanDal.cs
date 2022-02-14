using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class KurumsalDokumanDal : IKurumsalDokumanDal
    {
        public List<KurumsalDokuman> Ara(int id)
        {
            throw new NotImplementedException();
        }

        public List<KurumsalDokuman> Ara(string ad)
        {
            throw new NotImplementedException();
        }
       
        public List<KurumsalDokuman> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.KurumsalDokuman.ToList();
        }

        public void Ekle(KurumsalDokuman kurumsalDokuman)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.KurumsalDokuman.Add(kurumsalDokuman);
            ekle.SaveChanges();
        }
        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.KurumsalDokuman.Where(p => p.KdId == id).FirstOrDefault();
            sil.KurumsalDokuman.Remove(bul);
            sil.SaveChanges();
        }
    }
}
