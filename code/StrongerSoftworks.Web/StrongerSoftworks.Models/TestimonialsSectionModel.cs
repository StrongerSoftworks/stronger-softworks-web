using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongerSoftworks.Models
{
    public class TestimonialModel
    {
        public string Quote { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }

    public class TestimonialsSectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<TestimonialModel> Testimonials { get; set; }
    }

}
