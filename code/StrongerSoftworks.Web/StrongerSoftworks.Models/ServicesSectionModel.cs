using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class ServiceItemModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string Link { get; set; }
    }

    public class ServicesSectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<ServiceItemModel> ServiceItems { get; set; }
    }

}
