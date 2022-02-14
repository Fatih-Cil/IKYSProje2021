using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Abstract
{
    interface IGorevDal:IRepository<Gorev>
    {
        void Ekle(Gorev gorev);
        void Sil(int id);
        void Guncelle(int id, string gorevadi);
    }
}
