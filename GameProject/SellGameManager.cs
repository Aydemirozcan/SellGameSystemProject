using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SellGameManager:ISellGameManager
    {

        CampaignManager _campaignManager;

        public SellGameManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + ":"+ "Sold to" + gamer.FirstName   );
        }
    }
}
