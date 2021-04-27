using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} added!", game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} deleted!", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} updated!", game.Name);
        }
    }
}
