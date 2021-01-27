using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game, Player player,  Campaign campaign);
        //void SaleOfCampaign(Game game, Player player, Campaign campaign);
    }
}
