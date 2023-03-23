using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
