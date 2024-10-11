using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class PortfolioItemModel
    {
        public string Category { get; set; } // e.g., "filter-app", "filter-product"
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DetailsUrl { get; set; } // e.g., URL to the details page
    }

    public class PortfolioSectionModel : SectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<string> Categories { get; set; } // e.g., "App", "Product", "Branding", "Books"
        public List<PortfolioItemModel> PortfolioItems { get; set; }
    }

}
