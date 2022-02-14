using IKYSProjeWinUI.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYSProjeWinUI.Business
{
    class GirisKontrol
    {
       
        public int KontrolEt(string tcNo, string sifre)
        {
            PersonelDal sorgula = new PersonelDal();
            List<Personel> sonuc = sorgula.GirisAra(tcNo, sifre); //girilen bilgiler DAL clasında sorgulanıyor.


            if (sonuc.Count > 0) //dönen değer varsa işlem ve kontrol yapılıyor.
            {
                foreach (var item in sonuc)
                {
                    if (item.RolId != 3) //user yetkisi haricinde ise işlem yap.
                    {
                        MainScreen mainScreen = new MainScreen();

                        mainScreen.personelId = item.PersonelId;
                        mainScreen.personelAdi = item.Ad;
                        mainScreen.personelRolId = item.RolId;
                        
                        mainScreen.Show();
                    }
                    else
                    {
                        return 3;
                    }

                }
                 return 1;
            }
            else
            {
                return 0;
            }
        }

        
    }
}
