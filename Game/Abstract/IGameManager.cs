using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
