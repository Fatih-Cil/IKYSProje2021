using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.DataAccess
{
    class RolDal
    {
        public string RolAra(int deger)
        {

            IKYSProjeEntities db = new IKYSProjeEntities();
            var bul = db.Roller.Where(p => p.RolId == deger).FirstOrDefault();
            return bul.RolAdi;

        }


        public List<Roller> RolListele()
        {
            IKYSProjeEntities db = new IKYSProjeEntities();
            return db.Roller.ToList();

        }
    }
}
