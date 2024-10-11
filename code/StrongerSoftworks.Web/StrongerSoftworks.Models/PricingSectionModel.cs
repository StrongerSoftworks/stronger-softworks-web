using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class PricingItemModel
    {
        public string PlanName { get; set; } // e.g., "Free Plan", "Business Plan"
        public decimal Price { get; set; } // e.g., 0, 29, 49
        public string Frequency { get; set; } // e.g., " / month"
        public List<string> Features { get; set; } // Features included in the plan
        public List<string> ExcludedFeatures { get; set; } // Features not included in the plan
        public List<string> Addons { get; set; } // Features not included in the plan
        public bool IsFeatured { get; set; } // For the featured plan
    }

    public class PricingSectionModel : SectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<PricingItemModel> PricingItems { get; set; }
        public string CallToAction { get; set; } = "Buy Now";
        public string CallToActionTarget { get; set; } = "contact";
    }

}
