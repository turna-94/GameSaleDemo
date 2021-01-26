using System;
using GameSaleDemo.Entities;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Game game, Player player, Campaign campaign);
    }
}
