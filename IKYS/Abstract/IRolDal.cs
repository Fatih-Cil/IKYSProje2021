using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYS.Abstract
{
    interface IRolDal : IRepository<Roller> //generic olarak gelen sınıfa göre method yazılabilmesi için implement ediyorum.
    {
    }
}
