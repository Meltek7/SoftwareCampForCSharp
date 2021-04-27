using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, UserName = "Meltek", IdentityNumber = 123, FirstName = "Meltem", LastName = "Tekeli Akdağ", BirthYear = 1994 });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Id = 1, Name = "Legends", UnitPrice = 300 });

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new Order { Id = 1, UserId = 1, UserName = "Meltek", GameId = 1, GameName = "Legends" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, CampaignName = "20% Discount", OrderId = 1 });
        }
    }
}
