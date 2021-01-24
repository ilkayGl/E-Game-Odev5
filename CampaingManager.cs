using System;
using System.Collections.Generic;
using System.Text;

namespace E_Game
{
    class CampaingManager
    {
        public void CampaignAdd(Campaign campaign)
        {

            Console.WriteLine(campaign.CampaignType + " =>" + campaign.CampaignName + " adlı Kampanya Eklendi");
        }
        public void CampaignDeleted(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignType + " =>" + campaign.CampaignName + " adlı Kampanya Silindi.");
        }
    }
}
