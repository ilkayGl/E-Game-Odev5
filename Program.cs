using System;

namespace E_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "İlkay", LastName = "Gül", YearOfBirth = "27.02.1997", TcNo = "1234567890" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Ahmet", LastName = "Gül", YearOfBirth = "15.11.1985", TcNo = "2468012162" };
            Gamer gamer3 = new Gamer() { Id = 3, FirstName = "Salih", LastName = "Dekci", YearOfBirth = "17.07.1993", TcNo = "369121824" };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer3);

            Console.WriteLine("---------------------------------------------------------------");

            UserServiceManager userServiceManager = new UserServiceManager();
            userServiceManager.GamerCheck(new GamerCheck());
            userServiceManager.LoggerServices(new SqlGamerService());

            Console.WriteLine("---------------------------------------------------------------");




            Campaign campaign1 = new Campaign
            {
                CampaignType = "Kampanya",
                CampaignName = "Black Friday ",
                CampaignRatio = 0.25
            };
            Campaign campaign2 = new Campaign
            {
                CampaignType = "Kampanya",
                CampaignName = "Yılbaşı Özel",
                CampaignRatio = 1
            };

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.CampaignAdd(campaign1);
            campaingManager.CampaignDeleted(campaign2);

            Console.WriteLine("---------------------------------------------------------------");



            Product product1 = new Product()
            {
                GameName = "Gta 5",
                GamePrice = 180,
            };
            Product product2 = new Product()
            {
                GameName = "Football Manager 2021",
                GamePrice = 600,
            };

            GameTradeManager gameTradeManager = new GameTradeManager();

            gameTradeManager.GameBuy(gamer3, product1, campaign1);
            gameTradeManager.GameSell(gamer1, product2, campaign2);
        }
    }
}
