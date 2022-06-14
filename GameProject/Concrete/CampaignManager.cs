using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "Campaing deleted");
        }

        

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +  " -- CAMPAIGN SAVED ");
        }

        

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +  "Campaing updated");
        }

        
    }
}
