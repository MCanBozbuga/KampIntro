using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "-Game Deleted");
        }

        public void Save(Game game)
        {
            Console.WriteLine(game.Name + " --GAME SAVED");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "-Game Updated");
        }
    }
}
