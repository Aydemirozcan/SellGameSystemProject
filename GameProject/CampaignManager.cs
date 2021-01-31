using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignservice
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" : "+"Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" : "+ "Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" : "+"Updated");
        }
    }
}
