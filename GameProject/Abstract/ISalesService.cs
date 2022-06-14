using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISalesService
    {
        public void Buy2(Gamer gamer, Game game, Campaign campaign);
        public void Buy(Campaign campaign, Game game);
    }
}
