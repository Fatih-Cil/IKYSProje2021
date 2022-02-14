using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class LogDal:ILogDal
    {
        public List<Loglar> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.OrderByDescending(p=>p.Tarih).ToList();
        }

        public List<Loglar> Ara(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.LogId == id).ToList();
        }

        public List<Loglar> Ara(string eylem)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.Eylem == eylem).OrderByDescending(t => t.Tarih).ToList();
        }

        public void LogYaz(Loglar loglar)
        {
            IkysEntities ekle = new IkysEntities();
            ekle.Loglar.Add(loglar);
            ekle.SaveChanges();

        }

        public void LogGonder(string eylem, string modul, string AktifKullaniciAdi, int AktifKullaniciID)
        {

            //Log alıyorum.
            Loglar loglar = new Loglar();
            loglar.Eylem = eylem;
            loglar.Modul = modul;
            loglar.Aciklama = "İŞLEM YAPAN KULLANICI-'" + AktifKullaniciAdi + "'";
            loglar.PersonelId = AktifKullaniciID;
            loglar.Tarih = DateTime.Today;
            LogYaz(loglar);
        }
        public List<Loglar> EylemAra(string eylem)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.Eylem == eylem).OrderByDescending(t => t.Tarih).ToList();
        }
        public List<Loglar> ModulAra(string modul)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.Modul == modul).OrderByDescending(t => t.Tarih).ToList();
        }

        public List<Loglar> SicilNoAra(int id, string modul, DateTime tarih)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.PersonelId == id && p.Modul==modul && p.Tarih==tarih).OrderByDescending(t => t.Tarih).ToList();
        }

        
        public List<Loglar> CokluAra(string eylem,string modul, DateTime tarih)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.Modul == modul && p.Eylem==eylem && p.Tarih==tarih).OrderByDescending(t => t.Tarih).ToList();
        }

        public List<Loglar> TariheGoreAra(DateTime tarih)
        {
            IkysEntities context = new IkysEntities();
            return context.Loglar.Where(p => p.Tarih == tarih).OrderByDescending(t => t.Tarih).ToList();
        }

    }
}
