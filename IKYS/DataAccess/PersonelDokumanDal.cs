using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class PersonelDokumanDal : IPersonelDokumanDal
    {
        public List<PersonelDokuman> Ara(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonelDokuman> Ara(string ad)
        {
            throw new NotImplementedException();
        }

        public List<PersonelDokuman> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.PersonelDokuman.ToList();
        }
        public void Ekle(PersonelDokuman personelDokuman)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.PersonelDokuman.Add(personelDokuman);
            ekle.SaveChanges();
        }
        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.PersonelDokuman.Where(p => p.PdId == id).FirstOrDefault();
            sil.PersonelDokuman.Remove(bul);
            sil.SaveChanges();
        }

        public List<PersonelDokuman> PDKIdAra(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.PersonelDokuman.Where(p => p.PDKId == id).ToList();
        }
        public List<PersonelDokuman> PersonelIdiledAra(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.PersonelDokuman.Where(p => p.PersonelId == id).ToList();
        }
        public List<PersonelDokuman> PIDveKategoriAra(int Pid,int Kid)
        {
            IkysEntities context = new IkysEntities();
            return context.PersonelDokuman.Where(p => p.PersonelId == Pid && p.PDKId==Kid).ToList();
        }
    }
}
