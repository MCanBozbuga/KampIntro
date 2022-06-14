using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer Oyuncu1 = new Gamer{
                Id = 1,
                Name = "CAN",
                Surname = "Bozbuğa",
                NationalityId = 123456789,
                YearOfBirth = 1996,
                deneme=true              
            };
            Gamer Oyuncu2 = new Gamer
            {
                Id = 1,
                Name = "SİNAN",
                Surname = "İCİ",
                NationalityId = 123456789,
                YearOfBirth = 2001,
                deneme = true
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Save(Oyuncu1);
            //gamerManager.Save(Oyuncu2);

            if (Oyuncu1.deneme==true )
            {
                Campaign Kampanya1 = new Campaign { Id = 1, Name = " HAZİRAN AYI>>", Content = "5" };
                CampaignManager campaignManager = new CampaignManager();
                campaignManager.Save(Kampanya1);

                Game Oyun1 = new Game
                {
                    Id = 2,
                    Name = "  FİFA 2022",
                    Price = 40
                };
                GameManager gameManager = new GameManager();
                gameManager.Save(Oyun1);

                SalesManager salesManager = new SalesManager();
                salesManager.Buy2(Oyuncu1, Oyun1, Kampanya1);
            }
            else
            {
                Console.WriteLine("TEKRAR DENEYİNİZ.");
            }
            
            
            





        }
    }
}
