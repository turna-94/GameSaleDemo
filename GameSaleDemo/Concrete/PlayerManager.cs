using System;
using GameSaleDemo.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("The player has been deleted from the system : "+player.FirstName+" "+player.LastName);   
        }

        public void Save(Player player)
        {
            Console.WriteLine("The player has been saved to system : " + player.FirstName + " " + player.LastName);
         
        }

        public void Update(Player player)
        {
            Console.WriteLine("The player has been updated : "+player.FirstName+" "+player.LastName);   
        }
        
    }
}
