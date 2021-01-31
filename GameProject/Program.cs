using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());  --Eğer e-Devlet sistemi değişirse :
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IndentityNumber = 12345
            });

            Game game1 = new Game();
            game1.GameName = "GTA";
            game1.GamePrice = 5;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = " Aydemir";
            gamer2.LastName = "Özcan";
            gamer2.BirthYear = 1996;
            gamer2.IndentityNumber = 23456;
            gamer2.Id = 2;


            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "campaign Of GTA";
            campaign1.DiscountRate = "%5";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            SellGameManager sellGameManager = new SellGameManager(campaignManager);
            sellGameManager.Sell(game1,gamer2);
        
        }
    }
}
