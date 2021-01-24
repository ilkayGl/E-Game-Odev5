using System;
using System.Collections.Generic;
using System.Text;

namespace E_Game
{
    class GameTradeManager
    {
        public void GameBuy(Gamer gamer, Product product, Campaign campaign)
        {
            product.GamePrice = product.GamePrice - (product.GamePrice * campaign.CampaignRatio);
            Console.WriteLine(product.GamePrice + " " + "$    " + " " + gamer.FirstName + " adlı oyuncu" + " " + product.GameName + " " + "oyununu aldı.");
        }

        public void GameSell(Gamer gamer, Product product, Campaign campaign)
        {
            product.GamePrice = product.GamePrice - (product.GamePrice * campaign.CampaignRatio);
            Console.WriteLine(product.GamePrice + " " + "$    " + " " + gamer.FirstName + " adlı oyuncu" + " " + product.GameName + " " + "oyununu sattı.");

        }
    }
}
