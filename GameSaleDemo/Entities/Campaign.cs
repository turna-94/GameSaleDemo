using GameSaleDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
    }
}
