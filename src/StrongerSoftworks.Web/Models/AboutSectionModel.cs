using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Web.Models
{
    public class SectionItem {
        public string Title { get; set; }
        public string Content { get; set; }
        public PictureModel? Picture { get; set; }
    }

    public class AboutSectionModel : SectionModel
    {
        public string Header { get; set; }
        public string Paragraph { get; set; }
        public List<SectionItem> ListItems { get; set; }
    }

}
