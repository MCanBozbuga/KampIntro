using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    internal interface IGameService
    {
        public void Save(Game game);
        public void Update(Game game);
        public void Delete(Game game);
    }
}
