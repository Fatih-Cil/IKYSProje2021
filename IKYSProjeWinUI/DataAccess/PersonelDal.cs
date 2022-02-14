using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.DataAccess
{
    class PersonelDal
    {
        public List<Personel> GirisAra(string tcNo, string sifre)
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Personel.Where(p => p.TcNo == tcNo && p.Sifre == sifre && p.Durum == "AKTİF").ToList();

        }
        public List<Personel> PersonelListeleHepsi()
        {
            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Personel.ToList();

        }

        public List<Personel> AktifPersonelListesi()
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Personel.Where(p => p.Durum == "AKTİF").ToList();

        }
        public List<Personel> PasifPersonelListesi()
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Personel.Where(p => p.Durum == "PASİF").ToList();


        }
    }
}
