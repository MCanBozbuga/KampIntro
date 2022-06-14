using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Name=="CAN" && gamer.YearOfBirth==1996 || gamer.Name=="SİNAN" && gamer.YearOfBirth==2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
