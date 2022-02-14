using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Abstract
{
    interface IRepository<T>
    {
        //T degiskeni ile gelen değere göre methodları yazdım. bu interface ile methodları yazmaları zorunlu kılıyorum. 
        List<T> TumunuListele();
        List<T> Ara(int id);
        List<T> Ara(string ad);
    }
}
