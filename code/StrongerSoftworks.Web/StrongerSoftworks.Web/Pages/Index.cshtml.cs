using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrongerSoftworks.Models;

namespace StrongerSoftworks.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public HeroSectionModel HeroSection { get; private set; }
        public AboutSectionModel AboutSection { get; private set; }
        public StatsSectionModel StatsSection { get; private set; }
        public ServicesSectionModel ServicesSection { get; private set; }
        public FeaturesSectionModel FeaturesSection { get; private set; }
        public TestimonialsSectionModel TestimonialsSection { get; private set; }
        public PortfolioSectionModel PortfolioSection { get; private set; }
        public PricingSectionModel PricingSection { get; private set; }
        public FaqSectionModel FaqSection { get; private set; }
        public TeamSectionModel TeamSection { get; private set; }
        public ContactSectionModel ContactSection { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            HeroSection = new HeroSectionModel
            {
                Title = "Stronger Softworks",
                ButtonText = "<i class=\"bi bi-arrow-return-left\"></i> enter",
                ButtonLink = "#about",
            };

            AboutSection = new AboutSectionModel
            {
                Header = "Voluptatem dignissimos provident quasi corporis",
                Paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ListItems = new List<string>
                {
                    "Ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    "Duis aute irure dolor in reprehenderit in voluptate velit.",
                    "Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur."
                },
                ButtonText = "Read More",
                ButtonLink = "#",
                ImageUrl = "/img/about.jpg",
                ImageAltText = "About Image"
            };

            StatsSection = new StatsSectionModel
            {
                StatsItems = new List<StatsItemModel>
                {
                    new StatsItemModel { StartValue = 0, EndValue = 232, Duration = 1, Label = "Clients" },
                    new StatsItemModel { StartValue = 0, EndValue = 521, Duration = 1, Label = "Projects" },
                    new StatsItemModel { StartValue = 0, EndValue = 1453, Duration = 1, Label = "Hours Of Support" },
                    new StatsItemModel { StartValue = 0, EndValue = 32, Duration = 1, Label = "Workers" }
                }
            };

            ServicesSection = new ServicesSectionModel
            {
                SectionTitle = "Services",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                ServiceItems = new List<ServiceItemModel>
                {
                    new ServiceItemModel
                    {
                        Title = "Lorem Ipsum",
                        Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",
                        IconClass = "bi bi-briefcase",
                        Link = "#"
                    },
                    new ServiceItemModel
                    {
                        Title = "Dolor Sitema",
                        Description = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip exa",
                        IconClass = "bi bi-card-checklist",
                        Link = "#"
                    },
                    new ServiceItemModel
                    {
                        Title = "Sed ut perspiciatis",
                        Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum",
                        IconClass = "bi bi-bar-chart",
                        Link = "#"
                    },
                    new ServiceItemModel
                    {
                        Title = "Magni Dolores",
                        Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt",
                        IconClass = "bi bi-binoculars",
                        Link = "#"
                    },
                    new ServiceItemModel
                    {
                        Title = "Nemo Enim",
                        Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praese",
                        IconClass = "bi bi-brightness-high",
                        Link = "#"
                    },
                    new ServiceItemModel
                    {
                        Title = "Eiusmod Tempor",
                        Description = "Et harum quidem rerum facilis est et expedita distinctio dasa fermo lind saca",
                        IconClass = "bi bi-calendar4-week",
                        Link = "#"
                    }
                }
            };

            FeaturesSection = new FeaturesSectionModel
            {
                SectionTitle = "Features",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                ImageUrl = "/img/features.svg",
                FeatureItems = new List<FeatureItemModel>
                {
                    new FeatureItemModel
                    {
                        Title = "Est labore ad",
                        Description = "Consequuntur sunt aut quasi enim aliquam quae harum pariatur laboris nisi ut aliquip",
                        IconClass = "bi bi-archive"
                    },
                    new FeatureItemModel
                    {
                        Title = "Harum esse qui",
                        Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt",
                        IconClass = "bi bi-basket"
                    },
                    new FeatureItemModel
                    {
                        Title = "Aut occaecati",
                        Description = "Aut suscipit aut cum nemo deleniti aut omnis. Doloribus ut maiores omnis facere",
                        IconClass = "bi bi-broadcast"
                    },
                    new FeatureItemModel
                    {
                        Title = "Beatae veritatis",
                        Description = "Expedita veritatis consequuntur nihil tempore laudantium vitae denat pacta",
                        IconClass = "bi bi-camera-reels"
                    }
                }
            };

            TestimonialsSection = new TestimonialsSectionModel
            {
                SectionTitle = "Testimonials",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                Testimonials = new List<TestimonialModel>
                {
                    new TestimonialModel
                    {
                        Quote = "Proin iaculis purus consequat sem cure dignissim donec porttitora...",
                        ImageUrl = "/img/testimonials/testimonials-1.jpg",
                        Name = "Saul Goodman",
                        Title = "CEO & Founder"
                    },
                    new TestimonialModel
                    {
                        Quote = "Export tempor illum tamen malis malis eram quae irure esse labore...",
                        ImageUrl = "/img/testimonials/testimonials-2.jpg",
                        Name = "Sara Wilsson",
                        Title = "Designer"
                    },
                    new TestimonialModel
                    {
                        Quote = "Enim nisi quem export duis labore cillum quae magna enim sint...",
                        ImageUrl = "/img/testimonials/testimonials-3.jpg",
                        Name = "Jena Karlis",
                        Title = "Store Owner"
                    },
                    new TestimonialModel
                    {
                        Quote = "Fugiat enim eram quae cillum dolore dolor amet nulla culpa...",
                        ImageUrl = "/img/testimonials/testimonials-4.jpg",
                        Name = "Matt Brandon",
                        Title = "Freelancer"
                    },
                    new TestimonialModel
                    {
                        Quote = "Quis quorum aliqua sint quem legam fore sunt eram irure aliqua...",
                        ImageUrl = "/img/testimonials/testimonials-5.jpg",
                        Name = "John Larson",
                        Title = "Entrepreneur"
                    }
                }
            };

            PortfolioSection = new PortfolioSectionModel
            {
                SectionTitle = "Portfolio",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                Categories = new List<string> { "App", "Product", "Branding", "Books" },
                PortfolioItems = new List<PortfolioItemModel>
                {
                    new PortfolioItemModel
                    {
                        Category = "filter-app",
                        ImageUrl = "/img/portfolio/app-1.jpg",
                        Title = "App 1",
                        Description = "Lorem ipsum, dolor sit amet consectetur",
                        DetailsUrl = "portfolio-details.html"
                    },
                    new PortfolioItemModel
                    {
                        Category = "filter-product",
                        ImageUrl = "/img/portfolio/product-1.jpg",
                        Title = "Product 1",
                        Description = "Lorem ipsum, dolor sit amet consectetur",
                        DetailsUrl = "portfolio-details.html"
                    },
                    new PortfolioItemModel
                    {
                        Category = "filter-branding",
                        ImageUrl = "/img/portfolio/branding-1.jpg",
                        Title = "Branding 1",
                        Description = "Lorem ipsum, dolor sit amet consectetur",
                        DetailsUrl = "portfolio-details.html"
                    },
                }
            };

            PricingSection = new PricingSectionModel
            {
                SectionTitle = "Pricing",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                PricingItems = new List<PricingItemModel>
                {
                    new PricingItemModel
                    {
                        PlanName = "Business Starter",
                        Price = 625,
                        Frequency = "",
                        Features = new List<string> {
                            "Single page website",
                            "Contact form",
                            "Map",
                            "Google Analytics integration (GTM, GA4)",
                            "$15/month hosting and maintenance fees",
                        },
                        ExcludedFeatures = new List<string>()
                        {
                            "Content Management System with Strapi"
                        },
                        IsFeatured = false
                    },
                    new PricingItemModel
                    {
                        PlanName = "Business Starter With CMS",
                        Price = 1000,
                        Frequency = "",
                        Features = new List<string> {
                            "Single page website with CMS",
                            "Contact form",
                            "Map",
                            "Google Analytics integration (GTM, GA4)",
                            "Content Management System with Strapi",
                            "50gb storage",
                            "Weekly backups",
                            "$30/month hosting and maintenance fees",
                        },
                        Addons = new List<string>()
                        {
                            "Each additional page +$200",
                            "Appointment booking +$500",
                            "Blog +$1000",
                        },
                        IsFeatured = true
                    },
                    new PricingItemModel
                    {
                        PlanName = "Business Starter With CMS",
                        Price = 125,
                        Frequency = "/ month",
                        Features = new List<string> {
                            "Single page website with CMS",
                            "Contact form",
                            "Map",
                            "Google Analytics integration (GTM, GA4)",
                            "Content Management System with Strapi",
                            "50gb storage",
                            "Weekly backups",
                            "$0 up front for base package, 12 month obligation, add-ons paid on delivery",
                        },
                        Addons = new List<string>()
                        {
                            "Each additional page +$200",
                            "Appointment booking +$500",
                            "Blog +$1000",
                        },
                        IsFeatured = false
                    },
                    //new PricingItemModel
                    //{
                    //    PlanName = "E-Commerce",
                    //    Price = 4500,
                    //    Frequency = "",
                    //    Features = new List<string> {
                    //        "Contact form",
                    //        "Map",
                    //        "Google Analytics integration (GTM, GA4)",
                    //        "Content Management System",
                    //        "Integration with your ecommerce platform",
                    //        "200gb storage",
                    //        "Daily backups",
                    //        "150/month hosting and maintenance fees",
                    //    },
                    //    Addons = new List<string>()
                    //    {
                    //        "Each additional page +$200",
                    //        "Appointment booking +$500",
                    //        "Blog +$1000",
                    //    },
                    //    IsFeatured = false
                    //},
                }
            };

            FaqSection = new FaqSectionModel
            {
                SectionTitle = "Frequently Asked Questions",
                SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
                FaqItems = new List<FaqItemModel>
                {
                    new FaqItemModel
                    {
                        Question = "Non consectetur a erat nam at lectus urna duis?",
                        Answer = "Feugiat pretium nibh ipsum consequat. Tempus iaculis urna id volutpat lacus laoreet non curabitur gravida."
                    },
                    new FaqItemModel
                    {
                        Question = "Feugiat scelerisque varius morbi enim nunc faucibus?",
                        Answer = "Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices."
                    },
                    new FaqItemModel
                    {
                        Question = "Dolor sit amet consectetur adipiscing elit pellentesque?",
                        Answer = "Eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci. Faucibus pulvinar elementum integer enim."
                    },
                    new FaqItemModel
                    {
                        Question = "Ac odio tempor orci dapibus. Aliquam eleifend mi in nulla?",
                        Answer = "Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices."
                    },
                    new FaqItemModel
                    {
                        Question = "Tempus quam pellentesque nec nam aliquam sem et tortor?",
                        Answer = "Molestie a iaculis at erat pellentesque adipiscing commodo. Dignissim suspendisse in est ante in."
                    },
                    new FaqItemModel
                    {
                        Question = "Perspiciatis quod quo quos nulla quo illum ullam?",
                        Answer = "Enim ea facilis quaerat voluptas quidem et dolorem. Quis et consequatur non sed in suscipit sequi."
                    }
                }
            };

            TeamSection = new TeamSectionModel
            {
                TeamMembers = new List<TeamMember>
                {
                    new TeamMember
                    {
                        Name = "Walter White",
                        Position = "Chief Executive Officer",
                        Description = "Velit aut quia fugit et et. Dolorum ea voluptate vel tempore tenetur ipsa quae aut. Ipsum exercitationem iure minima enim corporis et voluptate.",
                        ImageUrl = "/img/team/team-1.jpg",
                        Delay = 100,
                        SocialLinks = new List<SocialLink>
                        {
                            new SocialLink { Url = "#", IconClass = "bi bi-twitter-x" },
                            new SocialLink { Url = "#", IconClass = "bi bi-facebook" },
                            new SocialLink { Url = "#", IconClass = "bi bi-instagram" },
                            new SocialLink { Url = "#", IconClass = "bi bi-linkedin" }
                        }
                    },
                    new TeamMember
                    {
                        Name = "Sarah Jhonson",
                        Position = "Product Manager",
                        Description = "Quo esse repellendus quia id. Est eum et accusantium pariatur fugit nihil minima suscipit corporis. Voluptate sed quas reiciendis animi neque sapiente.",
                        ImageUrl = "/img/team/team-2.jpg",
                        Delay = 200,
                        SocialLinks = new List<SocialLink>
                        {
                            new SocialLink { Url = "#", IconClass = "bi bi-twitter-x" },
                            new SocialLink { Url = "#", IconClass = "bi bi-facebook" },
                            new SocialLink { Url = "#", IconClass = "bi bi-instagram" },
                            new SocialLink { Url = "#", IconClass = "bi bi-linkedin" }
                        }
                    },
                    new TeamMember
                    {
                        Name = "William Anderson",
                        Position = "CTO",
                        Description = "Vero omnis enim consequatur. Voluptas consectetur unde qui molestiae deserunt. Voluptates enim aut architecto porro aspernatur molestiae modi.",
                        ImageUrl = "/img/team/team-3.jpg",
                        Delay = 300,
                        SocialLinks = new List<SocialLink>
                        {
                            new SocialLink { Url = "#", IconClass = "bi bi-twitter-x" },
                            new SocialLink { Url = "#", IconClass = "bi bi-facebook" },
                            new SocialLink { Url = "#", IconClass = "bi bi-instagram" },
                            new SocialLink { Url = "#", IconClass = "bi bi-linkedin" }
                        }
                    },
                    new TeamMember
                    {
                        Name = "Amanda Jepson",
                        Position = "Accountant",
                        Description = "Rerum voluptate non adipisci animi distinctio et deserunt amet voluptas. Quia aut aliquid doloremque ut possimus ipsum officia.",
                        ImageUrl = "/img/team/team-4.jpg",
                        Delay = 400,
                        SocialLinks = new List<SocialLink>
                        {
                            new SocialLink { Url = "#", IconClass = "bi bi-twitter-x" },
                            new SocialLink { Url = "#", IconClass = "bi bi-facebook" },
                            new SocialLink { Url = "#", IconClass = "bi bi-instagram" },
                            new SocialLink { Url = "#", IconClass = "bi bi-linkedin" }
                        }
                    }
                }
            };

            ContactSection = new ContactSectionModel
            {
                ContactInfos = new List<ContactInfo>
                {
                    new ContactInfo { Title = "Address", DetailLine1 = "A108 Adam Street", DetailLine2 = "New York, NY 535022", Icon = "bi bi-geo-alt" },
                    new ContactInfo { Title = "Call Us", DetailLine1 = "+1 5589 55488 55", DetailLine2 = "+1 6678 254445 41", Icon = "bi bi-telephone" },
                    new ContactInfo { Title = "Email Us", DetailLine1 = "info@example.com", DetailLine2 = "contact@example.com", Icon = "bi bi-envelope" },
                    //new ContactInfo { Title = "Open Hours", DetailLine1 = "Monday - Friday", DetailLine2 = "9:00AM - 05:00PM", Icon = "bi bi-clock" }
                }
            };
        }

        public void OnGet()
        {

        }
    }
}
