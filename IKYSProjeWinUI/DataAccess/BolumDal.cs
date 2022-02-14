using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.DataAccess
{
    class BolumDal
    {
        public List<Bolum> BolumListele()
        {
            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Bolum.ToList();

        }

        public string BolumAra(int deger)
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            var bul = db.Bolum.Where(p => p.BolumId == deger).FirstOrDefault();
            return bul.BolumAdi;


        }
    }
}
