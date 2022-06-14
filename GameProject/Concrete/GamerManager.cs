using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)   //Gamer Managerin içinde doğrulama yaptık.
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "-Gamer Deleted");
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("*** KAYIT BAŞARILI ***");
                Console.WriteLine(gamer.Name + " -->> GAMER SAVED");
                Console.WriteLine();
            }
            else
            {
                gamer.deneme = false;
                
                Console.WriteLine(" ****KAYIT BAŞARISIZ.***");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name +  "-Gamer Updated");

        }
    }
}
