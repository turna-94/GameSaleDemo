using System;
using GameSaleDemo.Entities;
using GameSaleDemo.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New campaign has been added : "+campaign.Name);
           
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The campaign has been deleted : "+campaign.Name);  
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The campaign has been updated : "+campaign.Name);
        }
    }
}
