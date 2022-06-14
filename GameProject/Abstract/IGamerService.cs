using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    internal interface IGamerService
    {
        public void Save(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);
    }
}
