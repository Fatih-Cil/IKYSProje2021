using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class BordroDal : IBordroDal
    {
        public List<Bordro> Ara(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bordro> Ara(string ad)
        {
            throw new NotImplementedException();
        }

        public List<Bordro> TumunuListele()
        {
            IkysEntities db = new IkysEntities();
            return db.Bordro.ToList();
        }

        public List<Bordro> TumunuListele(int pid, string ay,string yil)
        {
            IkysEntities db = new IkysEntities();
            return db.Bordro.Where(p=>p.PersonelId==pid && p.Tarih.Month.ToString()==ay && p.Tarih.Year.ToString() ==yil).ToList();
        }
        public List<Bordro> TumunuListele(string ay, string yil)
        {
            IkysEntities db = new IkysEntities();
            return db.Bordro.Where(p => p.Tarih.Month.ToString() == ay && p.Tarih.Year.ToString() == yil).ToList();
        }
        public void BordroEkle(Bordro bordro)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.Bordro.Add(bordro);
            ekle.SaveChanges();
        }

        public List<Bordro> PIDileAra(int id)
        {
            IkysEntities db = new IkysEntities();
            return db.Bordro.Where(p => p.PersonelId == id).ToList();
        }
        public List<Bordro> BordroKontrol(int pid, string ay, string yil)
        {
            IkysEntities db = new IkysEntities();
            return db.Bordro.Where(p => p.PersonelId == pid && p.Tarih.Month.ToString() == ay && p.Tarih.Year.ToString() == yil).ToList();

        }

        public void Sil(int id)
        {
            IkysEntities sil = new IkysEntities();
            var bul = sil.Bordro.Where(p => p.BordroId == id).FirstOrDefault();
            sil.Bordro.Remove(bul);
            sil.SaveChanges();
        }
    }
}
