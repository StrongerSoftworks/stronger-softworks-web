namespace StrongerSoftworks.Web.Models
{
    public class TestimonialModel
    {
        public string Quote { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }

    public class TestimonialsSectionModel : SectionModel
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<TestimonialModel> Testimonials { get; set; }
    }

}
