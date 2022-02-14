using IKYS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.DataAccess
{
    class RolDal : IRolDal //bu interface bir üstten aldığı mirası ve kendi üzerindeki varsa methodları yazmayı zorunlu kılıyor.  
    {
        public List<Roller> Ara(int id)
        {
            IkysEntities context = new IkysEntities();
            return context.Roller.Where(p => p.RolId == id).ToList();
        }

        public List<Roller> Ara(string ad)
        {
            throw new NotImplementedException();
        }

        public List<Roller> TumunuListele()
        {
            IkysEntities context = new IkysEntities();
            return context.Roller.ToList();
        }
    }
}
