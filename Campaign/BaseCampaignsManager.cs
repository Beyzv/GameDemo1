using GameDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Campaign
{
    public abstract class BaseCampaignsManager
    {
        public virtual void Add(Campaigns campaigns)
        {
            Console.WriteLine("Campaigns Added :" + campaigns.Name); ;
        }

        public virtual void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Campaigns Deleted :" + campaigns.Name); ;
        }
        public virtual void Upgrade(Campaigns campaigns)
        {
            Console.WriteLine("Campaigns Upgraded:" + campaigns.Name); ;
        }
    }
}
