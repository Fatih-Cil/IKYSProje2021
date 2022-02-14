using IKYS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYS.Business
{
    class GirisManager
    {
        public int KontrolEt(string TcNo, string Sifre)
        {
            if (TcNo == "" || Sifre == "")
            {
                MessageBox.Show("Alanlar Boş Geçilemez!");
                return 0;

            }
            else
            {
                MD5Sifreleme mD5Sifreleme = new MD5Sifreleme();
                string md5liSifre=mD5Sifreleme.MD5Sifrele(Sifre);

                PersonelDal personelDal = new PersonelDal();
                List<Personel> getir= personelDal.GirisAra(TcNo,md5liSifre);//bilgiler db sorgusu için yollanıyor.
                if (getir.Count > 0)
                {
                    foreach (var item in getir)
                    {
                        if (item.RolId==1003) //Giriş yapan user yetkisinde ise giriş izni verillmiyor.
                        {
                            MessageBox.Show("Giriş yetkiniz yok!"); return 0;
                        }
                        else
                        {
                            //giriş yapan diğer roller için ana sayfa oluşturuluyor ve giriş yapanın id, ad ve rolü ana sayfaya aktarılıyor.
                            AnaSayfa anaSayfa = new AnaSayfa();
                            anaSayfa.AktifId = item.PersonelId; 
                            anaSayfa.AktifAd = item.Ad;
                            anaSayfa.AktifRol = item.RolId;
                            anaSayfa.Show(); return 1;
                        }
                        
                    }
                    return 0;
                    



                }
                else
                {
                    MessageBox.Show("Giriş Başarısız! TC no ve Şifrenizi kontrol ediniz. "); 
                    return 0;

                } 
                    
                
            }

        }
    }
}
