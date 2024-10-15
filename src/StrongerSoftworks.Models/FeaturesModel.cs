using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class FeatureItemModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
    }

    public class FeaturesSectionModel : SectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public string LowerDescription { get; set; }
        public string PngUrl { get; set; }
        public List<FeatureItemModel> FeatureItems { get; set; }
    }

}
