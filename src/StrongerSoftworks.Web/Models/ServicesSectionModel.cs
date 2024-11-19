using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Web.Models
{
    public class ServiceItemModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string Link { get; set; }
    }

    public class ServicesSectionModel : SectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<ServiceItemModel> ServiceItems { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAltText { get; set; }
    }

}
