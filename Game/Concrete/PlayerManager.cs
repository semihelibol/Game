using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager : IPlayerManager,IPlayerCheckService

    {
        

        public void Add(Player player)
        {
            if (CheckIfRealPlayer(player))
            {
                Console.WriteLine("Oyuncu Kaydedildi...:" + player.FirstName);
            }
            else
                Console.WriteLine("Hata!!! Oyuncu kimlik Bilgileri Uyuşmuyor...");
        }

        public bool CheckIfRealPlayer(Player player)
        {
            bool result;
            try
            {
                IPlayerCheckService playerCheckManager = new MernisServiceAdapter();
                result = playerCheckManager.CheckIfRealPlayer(player);
            }
            catch
            {
                IPlayerCheckService playerCheckManager = new PlayerCheckManager();
                result = playerCheckManager.CheckIfRealPlayer(player);
            }
            return result;
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu Silindi...:" + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi...:" + player.FirstName);
        }
    }
}
