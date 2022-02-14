using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class PersonelDal
    {
        public List<Personel> GirisAra(string tcNo, string sifre)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.TcNo == tcNo && p.Sifre == sifre && p.Durum == "AKTİF").ToList();
        }

        public Personel PersonelAra(int id)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.PersonelId == id).FirstOrDefault();
        }
        public List<Personel> PersonelTcNoAra(string tc)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.TcNo == tc).ToList();
        }
        public List<Personel> SicilNoAra(int id)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.SicilNo == id).ToList();
        }
        public List<Personel> SicilNoAra(int id, string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.SicilNo == id && p.Durum == durum).ToList();
        }
        public List<Personel> TumunuListele()
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.ToList();
        }
        
        public List<Personel> TumunuListele(string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.Durum == durum).ToList();
        }
        public List<Personel> DogumTarihiYaklasan(string ay, string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.DogumTarihi.Value.Month.ToString() == ay && p.Durum == durum).ToList();
        }
        public List<Personel> KidemTarihiYaklasan(string ay, string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.IseGiris.Month.ToString() == ay && p.Durum == durum).ToList();
        }

        public List<Personel> PersonelAdindaAra(string key)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.Ad.Contains(key)).ToList();
        }
        public List<Personel> BolumIdIleAra(int id, string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.BolumId == id && p.Durum == durum).ToList();
        }
        public List<Personel> KanGrubuAra(string kg, string durum)
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.Where(p => p.KanGrubu == kg && p.Durum == durum).ToList();
        }

        public Personel SonPersonel()
        {
            IkysEntities db = new IkysEntities();
            return db.Personel.ToList().LastOrDefault();
        }
        public void PersonelEkle(Personel personel)
        {

            IkysEntities ekle = new IkysEntities();
            ekle.Personel.Add(personel);
            ekle.SaveChanges();
        }
        public void PersonelSil(int sicilNo)
        {

            IkysEntities sil = new IkysEntities();
            var bul = sil.Personel.Where(p => p.SicilNo == sicilNo).FirstOrDefault();
            bul.TcNo = "***"; bul.Ad = "***"; bul.Soyad = "***";
            bul.DogumTarihi = DateTime.Now;
            bul.Cep = "***";
            bul.Eposta = "***"; bul.Adres = "***"; bul.Sifre = "***";
            bul.KanGrubu = "***";
            bul.Durum = "PASİF";
            sil.SaveChanges();
             
        }
        public void Guncelle(int personelId, string tcno, string ad, string soyad, string cep, string eposta, string adres, string sifre,  double yillikizin,double maas, string ozelsaglik, string kangrubu, int bolumid, int gorevid, int rolid, DateTime dtarih, DateTime igiris,string durum)

        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.Personel.Where(p => p.PersonelId == personelId).FirstOrDefault();
            bul.TcNo = tcno; bul.Ad = ad; bul.Soyad = soyad;
            bul.DogumTarihi = dtarih.Date;
            bul.Cep = cep;
            bul.Eposta = eposta; bul.Adres = adres;
            if (sifre != "***") { bul.Sifre =  sifre; }
           
            bul.Maas = maas; bul.OzelSaglik = ozelsaglik; bul.KanGrubu = kangrubu;
            bul.IseGiris = igiris.Date;
            bul.Durum = durum;       
            bul.BolumId = bolumid; bul.GorevId = gorevid; bul.RolId = rolid;
            bul.YillikIzin = yillikizin;
            guncelle.SaveChanges();
        }
        public void PersonelCikis(int sicilno, DateTime icikis, string durum)

        {
            IkysEntities guncelle = new IkysEntities();
            var bul = guncelle.Personel.Where(p => p.SicilNo == sicilno).FirstOrDefault();
            bul.IstenCikis = icikis.Date;
            bul.Durum = durum;
            guncelle.SaveChanges();
        }

    }
}
