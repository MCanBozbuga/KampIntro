using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void Buy(Campaign campaign, Game game)
        {
            throw new NotImplementedException();
        }

        public void Buy2(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Name+"  İSİMLİ OYUNCU  "+ game.Name+"  OYUNU  "+game.Price+"  TL'YE SATIN ALDI. " 
                +gamer.Name+ " İSİMLİ OYUNCU " + campaign.Name+"  KAMPANYASINDAN FAYDALANMIŞTIR. " );
        }
    }
}
