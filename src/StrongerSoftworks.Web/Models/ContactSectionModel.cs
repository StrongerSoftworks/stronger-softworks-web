using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Web.Models
{
    public class ContactSectionModel : SectionModel
    {
        public List<ContactInfo> ContactInfos { get; set; }
    }

    public class ContactInfo
    {
        public string Title { get; set; }
        public string DetailLine1 { get; set; }
        public string DetailLine2 { get; set; }
        public string Icon { get; set; }
    }
}
