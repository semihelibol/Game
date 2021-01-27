using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Kaydedildi...:" + campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi...:" + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi...:" + campaign.Name);
        }
    }
}
