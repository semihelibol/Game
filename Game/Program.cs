using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using GameDemo.Entities.Abstract;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Semih";
            player1.LastName = "Elibol";
            player1.PlayerName = "semihelibol";
            player1.PlayerPassword = "111111";
            player1.TcNumber = "11111111111";
            player1.MailAdress = "sss@sss.com";
            player1.PhoneNumber = "555 55 55";
            player1.DateOfBirth = new DateTime(1986, 2, 22);
            player1.Adress = "Türkiye";
            player1.Balance = 50;
            player1.Bonus = 30;


            PlayerManager playerManager = new PlayerManager();
            
            playerManager.Add(player1);



            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Pubg";
            game1.Description = "Aksiyon";
            game1.Price = 70;
            game1.Stock = 10;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);


            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Büyük İndirim";
            campaign1.DiscountRate = 10;
            campaign1.StartDate = new DateTime(2021, 1, 1);
            campaign1.EndDate = new DateTime(2021, 3, 1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            CampaignSaleManager campaignSaleManager = new CampaignSaleManager();
            //Kampanyasız satın alma
            campaignSaleManager.Sale(game1,player1);

            //Kampanyalı satın alma
            campaignSaleManager.Sale(game1,player1,campaign1);

                

        }
    }
}
