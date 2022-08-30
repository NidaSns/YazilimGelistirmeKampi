using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager };
            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService,fileLogerService };

            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            // basvuruManager.KrediOnBilgilemdirmesiYap(krediler);
        }
    }
}
