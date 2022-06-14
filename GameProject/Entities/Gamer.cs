using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    internal class Gamer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long NationalityId { get; set; }
        public int YearOfBirth { get; set; }
        public bool deneme { get; set; }
    }
}
