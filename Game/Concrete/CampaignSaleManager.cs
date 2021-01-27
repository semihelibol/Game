using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class CampaignSaleManager : IGameSaleService
    {
        public void Sale(Game game, Player player, Campaign campaign=null)
        {
            if (campaign == null)
            {
                Console.WriteLine(player.FirstName + " oyuncusu " + game.Name + " oyunu kampanyasız satın aldı...");
            }
            else
            {
                Console.WriteLine(player.FirstName + " oyuncusu " + game.Name + " oyunu " + campaign.Name + " kampanyasıyla satın aldı...");
            }

            
        }
    }
}
