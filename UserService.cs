using System;
using System.Collections.Generic;
using System.Text;

namespace E_Game
{
    interface IGamerService
    {
        void CheckGamer();
    }

    interface ILoggerService
    {
        void LogService();
    }

    class GamerCheck : IGamerService
    {
        public void CheckGamer()
        {
            Console.WriteLine("Kullanıcı Kontrol Edildi...");
        }
    }

    class SqlGamerService : IGamerService, ILoggerService
    {
        public void CheckGamer()
        {
            Console.WriteLine("Kullanıcı Sql'de Doğrulandı");
        }

        public void LogService()
        {
            Console.WriteLine("Sql'e Loglama İşlemi Başarılı");
        }
    }
}
