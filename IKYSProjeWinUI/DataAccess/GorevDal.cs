using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.DataAccess
{
    class GorevDal
    {
        public string GorevAra(int deger)
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            var bul = db.Gorev.Where(p => p.GorevId == deger).FirstOrDefault();
            return bul.GorevAdi;


        }

        public List<Gorev> GorevListele()
        {
            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Gorev.ToList();

        }
    }
}
