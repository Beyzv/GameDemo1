using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignsManager
    {
        public void Add(Campaigns campaigns)
        {
            Console.WriteLine("Campaign added !");
        }
        public void Delete(Campaigns campaigns)
        {
            Console.WriteLine("Campaing Deleted !");
        }
        public void Upgrade(Campaigns campaigns)
        {
            Console.WriteLine("Campaing upgraded ! ");
        }
    }
}
