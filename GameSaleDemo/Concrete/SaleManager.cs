using System;
using GameSaleDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game, Player player, Campaign campaign)
        {
            if (player.DateOfBirth.Year >2001)
            {
                Console.WriteLine("Congrutulations! The second game is half price");
            }
     
            else
            {
                Console.WriteLine("There is a small campaign");
            }

            if (game.Price >=200.0)
            {
                Console.WriteLine("25% discount on purchases over 200 TL : " + campaign.Name);
            }
            else
            {
                Console.WriteLine("5% discount on purchases under 200 TL");
            }
        }
    }
}
