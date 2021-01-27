using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class PlayerCheckManager : IPlayerCheckService

    {
        
        public bool CheckIfRealPlayer(Player player)
        {
            //Tckimlik sorgulama çalışmazsa başka bir servis kullanıyoruz..
            return true;
        }
    }
}
