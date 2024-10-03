using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class AboutSectionModel
    {
        public string Header { get; set; }
        public string Paragraph { get; set; }
        public List<string> ListItems { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAltText { get; set; }
    }

}
