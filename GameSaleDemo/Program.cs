using System;
using System.Collections.Generic;
using GameSaleDemo.Abstract;
using GameSaleDemo.Concrete;
using GameSaleDemo.Entities;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Id = 1, FirstName = "Ali", LastName = "Turan", DateOfBirth = new DateTime(1999, 6, 12),NationalityId="12345678901" };
            Player player2=new Player { Id = 2, FirstName = "Şeyma", LastName = "Kaymak", DateOfBirth = new DateTime(2001, 4, 7), NationalityId = "37565432125" };
            Player player3=new Player { Id = 3, FirstName = "Salim", LastName = "Ay", DateOfBirth = new DateTime(2002, 11, 20), NationalityId = "78254386410" };
            Player player4=new Player {Id = 4, FirstName = "Funda", LastName = "Özyiğit", DateOfBirth = new DateTime(1996, 5, 30), NationalityId = "75325468724" };
            Player player5=new Player { Id = 5, FirstName = "Davut", LastName = "Zeynel", DateOfBirth = new DateTime(1984, 7, 18), NationalityId = "33254285368" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Save(player1);
            playerManager.Save(player2);
            playerManager.Save(player3);
            playerManager.Save(player4);
            playerManager.Save(player5);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(new Game { GameId = 1, Name = "GTA 5", Price = 200.0 }, player3, new Campaign { CampaignId = 12, Name = "Super discount!!" });
            saleManager.Sale(new Game { GameId = 2, Name = "FIFA 2019", Price = 150.0 }, player4, new Campaign {});
        }

    }
}
