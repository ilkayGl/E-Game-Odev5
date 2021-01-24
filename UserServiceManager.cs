using System;
using System.Collections.Generic;
using System.Text;

namespace E_Game
{
    class UserServiceManager
    {
        public void GamerCheck(IGamerService gamerService)
        {
            gamerService.CheckGamer();
        }

        public void LoggerServices(ILoggerService loggerService)
        {
            loggerService.LogService();
        }
    }
}
