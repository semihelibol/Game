using GameDemo.Entities;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        
    }
}
