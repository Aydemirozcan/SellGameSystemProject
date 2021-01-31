using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignservice
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
