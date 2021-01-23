using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var logerService in loggerServices)
            {
                logerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
