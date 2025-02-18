﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)//tek bir kredi hesabı yapıyoruz ve onu logluyoruz.
        {
            //Başvuran bilgileriini değerlendirme
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)//birden fazla kredinin hesabını yapabiliriz.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
