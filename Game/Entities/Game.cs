using GameDemo.Abstract;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GameType { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
