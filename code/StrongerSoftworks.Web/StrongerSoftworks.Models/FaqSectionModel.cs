using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class FaqItemModel
    {
        public string Question { get; set; } // The FAQ question
        public string Answer { get; set; }   // The FAQ answer
    }

    public class FaqSectionModel
    {
        public string SectionTitle { get; set; }    // Title of the FAQ section
        public string SectionDescription { get; set; } // Description of the FAQ section
        public List<FaqItemModel> FaqItems { get; set; } // List of FAQ items
    }

}
