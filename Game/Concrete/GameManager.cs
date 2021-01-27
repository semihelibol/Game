using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager:IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Kaydedildi...:" + game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi...:" + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi...:" + game.Name);
        }

        
    }
}
