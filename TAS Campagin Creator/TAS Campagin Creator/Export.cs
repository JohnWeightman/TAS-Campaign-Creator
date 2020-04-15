using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TAS_Campagin_Creator
{
    static class Export
    {
        static int TotalJobs = 0;
        static int CampaignJobs = 1;
        static int ModuleJobs = 0;

        public static void ExportCampaign(Campaign Campaign)
        {
            CalculateJobs(Campaign);
        }

        static void CalculateJobs(Campaign Campaign)
        {
            ModuleJobs = Campaign.Modules.Count;
            TotalJobs = CampaignJobs + ModuleJobs;
        }
    }
}
