using Microsoft.AspNetCore.Components;
using StrongerSoftworks.Models;

namespace StrongerSoftworks.Web.Components.Pages
{
    public partial class Home : ComponentBase
    {
        public HeroSectionModel? HeroData { get; private set; }
        public AboutSectionModel? AboutData { get; private set; }
        //public StatsSectionModel? StatsData { get; private set; }
        public ServicesSectionModel? ServicesData { get; private set; }
        public FeaturesSectionModel? FeaturesData { get; private set; }
        //public TestimonialsSectionModel? TestimonialsData { get; private set; }
        public PortfolioSectionModel? PortfolioData { get; private set; }
        public PricingSectionModel? PricingData { get; private set; }
        public FaqSectionModel? FaqData { get; private set; }
        public TeamSectionModel? TeamData { get; private set; }
        public ContactSectionModel? ContactData { get; private set; }

        protected override void OnParametersSet()
        {
            HeroData = new HeroSectionModel
            {
                Title = "Stronger Softworks",
                ButtonText = "<i class=\"bi bi-arrow-return-left\"></i> enter",
                ButtonLink = "#about",
            };

            AboutData = new AboutSectionModel
            {
                Header = "Let Us Help You Grow Your Business",
                Paragraph = "",
                ListItems = new List<string>
                {
                    "In today's digital age, having a strong online presence is crucial for businesses to thrive. At Stronger Softworks, we specialize in creating custom websites that not only reflect your brand's unique identity but also drive business growth. Whether you're looking to attract more customers or improve your customer experience, we provide tailored solutions designed to meet your goals.",
                    "We understand the specific challenges that businesses face, which is why we focus on building websites that are affordable, easy to manage, and scalable. Our responsive designs ensure that your site looks and works perfectly across all devices—whether it's a desktop, tablet, or mobile phone. We also integrate features like content management systems (CMS) that allow you to easily update your website, keeping it fresh and relevant without the need for technical expertise.",
                    "Beyond web design, we offer search engine optimization (SEO) services to help your business get noticed. We optimize your site with the right keywords, improve page load times, and ensure a user-friendly experience—all to help you rank higher on search engines like Google. Our local SEO strategies will also ensure that customers in your area can find you quickly and easily. Let us help you grow your business with a website that not only looks great but also drives results.",
                },
                // ButtonText = "Read More",
                // ButtonLink = "#",
                // ImageUrl = "/bundle/img/stronger-softworks.webp",
                // ImageAltText = "Stronger Softworks logo in a computer screen"
            };

            // StatsData = new StatsSectionModel
            // {
            //     StatsItems = new List<StatsItemModel>
            //     {
            //         new StatsItemModel { StartValue = 0, EndValue = 232, Duration = 1, Label = "Clients" },
            //         new StatsItemModel { StartValue = 0, EndValue = 521, Duration = 1, Label = "Projects" },
            //         new StatsItemModel { StartValue = 0, EndValue = 1453, Duration = 1, Label = "Hours Of Support" },
            //         new StatsItemModel { StartValue = 0, EndValue = 32, Duration = 1, Label = "Workers" }
            //     }
            // };

            ServicesData = new ServicesSectionModel
            {
                Id = "web-development",
                SectionTitle = "Our Web Development Services",
                SectionDescription = "At our web development company, we specialize in creating, designing, and maintaining websites that help businesses of all sizes succeed online. We handle the entire website development process—from the initial concept and design to the final deployment—ensuring that each website meets the unique needs of our clients and aligns with their business goals.",
                ImageUrl = "/bundle/img/stronger-softworks-logo-no-bg.avif",
                ImageAltText = "Stronger Softworks logo in a computer screen",
                ServiceItems = new List<ServiceItemModel>
                {
                    new ServiceItemModel
                    {
                        Title = "Custom Website Design",
                        Description = "We craft custom designs tailored to your brand, ensuring your website stands out and leaves a lasting impression on your target audience.",
                        IconClass = "bi bi-code-slash",
                    },
                    new ServiceItemModel
                    {
                        Title = "Responsive Design",
                        Description = "Our websites are fully responsive, meaning they work seamlessly across all devices, from desktops to smartphones, delivering an optimal experience no matter how your customers view your site.",
                        IconClass = "bi bi-phone",
                    },
                    new ServiceItemModel
                    {
                        Title = "User-Friendly Interfaces",
                        Description = "We prioritize usability by developing intuitive, easy-to-navigate websites that enhance user experience and encourage engagement.",
                        IconClass = "bi bi-card-checklist",
                    },
                    // new ServiceItemModel
                    // {
                    //     Title = "E-Commerce Solutions",
                    //     Description = "For businesses looking to sell products or services online, we provide e-commerce platforms with secure payment processing, inventory management, and shipping integration to meet your online sales needs.",
                    //     IconClass = "bi bi-binoculars",
                    // },
                    // new ServiceItemModel
                    // {
                    //     Title = "Content Management Systems (CMS)",
                    //     Description = "We empower businesses by implementing easy-to-use CMS platforms like WordPress or Shopify, allowing you to update content effortlessly without needing technical expertise.",
                    //     IconClass = "bi bi-brightness-high",
                    // },
                    new ServiceItemModel
                    {
                        Title = "Website Security",
                        Description = "Protecting your site and user data is a top priority. We integrate SSL certificates, security scans, and monitoring systems to ensure your site is secure against potential threats.",
                        IconClass = "bi bi-lock",
                    },
                    new ServiceItemModel
                    {
                        Title = "Scalability",
                        Description = "We build websites that are designed to grow with your business, making it easy to add new features or handle increased traffic as your company expands.",
                        IconClass = "bi bi-graph-up-arrow",
                    },
                    new ServiceItemModel
                    {
                        Title = "Ongoing Maintenance and Support",
                        Description = "Our services don't stop at launch. We provide ongoing maintenance, updates, and technical support to keep your website running smoothly and securely.",
                        IconClass = "bi bi-hammer",
                    }
                }
            };

            FeaturesData = new FeaturesSectionModel
            {
                Id = "seo",
                SectionTitle = "SEO Services to Boost Your Business",
                SectionDescription = "In addition to web development, we offer a range of search engine optimization (SEO) services to help your business get noticed and drive traffic.",
                LowerDescription = "By offering these comprehensive web development and SEO services, we help small and medium businesses not only create a strong online presence but also turn that presence into growth, engagement, and success.",
                ImageUrl = "/bundle/img/desk.png",
                FeatureItems = new List<FeatureItemModel>
                {
                    new FeatureItemModel
                    {
                        Title = "SEO Audit",
                        Description = "We provide a comprehensive analysis of you website's performance in search engines. It identifies areas for improvement, such as site structure, content, technical issues, and backlink quality, to ensure the site is optimized for higher rankings and better user experience.",
                        IconClass = "bi bi-list-columns"
                    },
                    new FeatureItemModel
                    {
                        Title = "Keyword Research",
                        Description = "We identify the keywords that matter most to your business, targeting what your potential customers are searching for to improve your site's search engine rankings.",
                        IconClass = "bi bi-search"
                    },
                    new FeatureItemModel
                    {
                        Title = "On-Page SEO Optimization",
                        Description = "By optimizing titles, meta descriptions, and content, we ensure your site is fully optimized for search engines like Google, helping you rank higher and attract more traffic.",
                        IconClass = "bi bi-body-text"
                    },
                    // new FeatureItemModel
                    // {
                    //     Title = "Content Creation",
                    //     Description = "We produce high-quality, SEO-optimized content, including blog posts, landing pages, and product descriptions, that attract visitors and establish your authority in your industry.",
                    //     IconClass = "bi bi-camera-reels"
                    // },
                    new FeatureItemModel
                    {
                        Title = "Local SEO Marketing",
                        Description = "We help local businesses by optimizing your site for location-specific searches, ensuring your business appears in relevant local search results and maps.",
                        IconClass = "bi bi-pin-map"
                    },
                    new FeatureItemModel
                    {
                        Title = "Mobile Optimization",
                        Description = "With mobile devices being a primary way people browse, we ensure your website is fast, functional, and fully optimized for mobile to keep you ahead in search rankings.",
                        IconClass = "bi bi-phone"
                    },
                    new FeatureItemModel
                    {
                        Title = "Technical SEO",
                        Description = "We improve your website's technical aspects, from site speed and crawlability to indexing and site architecture, to ensure optimal performance in search engines.",
                        IconClass = "bi bi-code-slash"
                    },
                    new FeatureItemModel
                    {
                        Title = "Analytics and Reporting",
                        Description = "We provide detailed reports on website traffic, keyword rankings, and user behavior, helping you make data-driven decisions to grow your online presence.",
                        IconClass = "bi bi-graph-up"
                    },
                    // TODO Learn how to do this
                    // new FeatureItemModel
                    // {
                    //     Title = "Link Building",
                    //     Description = "Our team develops strategies to acquire high-quality backlinks from reputable sites, boosting your site's credibility and improving search rankings.",
                    //     IconClass = "bi bi-link-45deg"
                    // }
                }
            };

            //TestimonialsData = new TestimonialsSectionModel
            //{
            //    SectionTitle = "Testimonials",
            //    SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
            //    Testimonials = new List<TestimonialModel>
            //    {
            //        new TestimonialModel
            //        {
            //            Quote = "Proin iaculis purus consequat sem cure dignissim donec porttitora...",
            //            ImageUrl = "/bundle/img/testimonials/testimonials-1.png",
            //            Name = "Saul Goodman",
            //            Title = "CEO & Founder"
            //        },
            //        new TestimonialModel
            //        {
            //            Quote = "Export tempor illum tamen malis malis eram quae irure esse labore...",
            //            ImageUrl = "/bundle/img/testimonials/testimonials-2.png",
            //            Name = "Sara Wilsson",
            //            Title = "Designer"
            //        },
            //        new TestimonialModel
            //        {
            //            Quote = "Enim nisi quem export duis labore cillum quae magna enim sint...",
            //            ImageUrl = "/bundle/img/testimonials/testimonials-3.png",
            //            Name = "Jena Karlis",
            //            Title = "Store Owner"
            //        },
            //        new TestimonialModel
            //        {
            //            Quote = "Fugiat enim eram quae cillum dolore dolor amet nulla culpa...",
            //            ImageUrl = "/bundle/img/testimonials/testimonials-4.png",
            //            Name = "Matt Brandon",
            //            Title = "Freelancer"
            //        },
            //        new TestimonialModel
            //        {
            //            Quote = "Quis quorum aliqua sint quem legam fore sunt eram irure aliqua...",
            //            ImageUrl = "/bundle/img/testimonials/testimonials-5.png",
            //            Name = "John Larson",
            //            Title = "Entrepreneur"
            //        }
            //    }
            //};

            // PortfolioData = new PortfolioSectionModel
            // {
            //     SectionTitle = "Portfolio",
            //     SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
            //     Categories = new List<string> { "App", "Product", "Branding", "Books" },
            //     PortfolioItems = new List<PortfolioItemModel>
            //     {
            //         new PortfolioItemModel
            //         {
            //             Category = "filter-app",
            //             ImageUrl = "/bundle/img/portfolio/app-1.png",
            //             Title = "App 1",
            //             Description = "Lorem ipsum, dolor sit amet consectetur",
            //             DetailsUrl = "portfolio-details.html"
            //         },
            //         new PortfolioItemModel
            //         {
            //             Category = "filter-product",
            //             ImageUrl = "/bundle/img/portfolio/product-1.png",
            //             Title = "Product 1",
            //             Description = "Lorem ipsum, dolor sit amet consectetur",
            //             DetailsUrl = "portfolio-details.html"
            //         },
            //         new PortfolioItemModel
            //         {
            //             Category = "filter-branding",
            //             ImageUrl = "/bundle/img/portfolio/branding-1.png",
            //             Title = "Branding 1",
            //             Description = "Lorem ipsum, dolor sit amet consectetur",
            //             DetailsUrl = "portfolio-details.html"
            //         },
            //     }
            // };

            // PricingData = new PricingSectionModel
            // {
            //     SectionTitle = "Pricing",
            //     SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
            //     PricingItems = new List<PricingItemModel>
            //     {
            //         new PricingItemModel
            //         {
            //             PlanName = "Business Starter",
            //             Price = 625,
            //             Frequency = "",
            //             Features = new List<string> {
            //                 "Single page website",
            //                 "Contact form",
            //                 "Map",
            //                 "Google Analytics integration (GTM, GA4)",
            //                 "$15/month hosting and maintenance fees",
            //             },
            //             ExcludedFeatures = new List<string>()
            //             {
            //                 "Content Management System with Strapi"
            //             },
            //             IsFeatured = false
            //         },
            //         new PricingItemModel
            //         {
            //             PlanName = "Business Starter With CMS",
            //             Price = 1000,
            //             Frequency = "",
            //             Features = new List<string> {
            //                 "Single page website with CMS",
            //                 "Contact form",
            //                 "Map",
            //                 "Google Analytics integration (GTM, GA4)",
            //                 "Content Management System with Strapi",
            //                 "50gb storage",
            //                 "Weekly backups",
            //                 "$30/month hosting and maintenance fees",
            //             },
            //             Addons = new List<string>()
            //             {
            //                 "Each additional page +$200",
            //                 "Appointment booking +$500",
            //                 "Blog +$1000",
            //             },
            //             IsFeatured = true
            //         },
            //         new PricingItemModel
            //         {
            //             PlanName = "Business Starter With CMS",
            //             Price = 125,
            //             Frequency = "/ month",
            //             Features = new List<string> {
            //                 "Single page website with CMS",
            //                 "Contact form",
            //                 "Map",
            //                 "Google Analytics integration (GTM, GA4)",
            //                 "Content Management System with Strapi",
            //                 "50gb storage",
            //                 "Weekly backups",
            //                 "$0 up front for base package, 12 month obligation, add-ons paid on delivery",
            //             },
            //             Addons = new List<string>()
            //             {
            //                 "Each additional page +$200",
            //                 "Appointment booking +$500",
            //                 "Blog +$1000",
            //             },
            //             IsFeatured = false
            //         },
            //     }
            // };

            // FaqData = new FaqSectionModel
            // {
            //     SectionTitle = "Frequently Asked Questions",
            //     SectionDescription = "Necessitatibus eius consequatur ex aliquid fuga eum quidem sint consectetur velit",
            //     FaqItems = new List<FaqItemModel>
            //     {
            //         new FaqItemModel
            //         {
            //             Question = "Non consectetur a erat nam at lectus urna duis?",
            //             Answer = "Feugiat pretium nibh ipsum consequat. Tempus iaculis urna id volutpat lacus laoreet non curabitur gravida."
            //         },
            //         new FaqItemModel
            //         {
            //             Question = "Feugiat scelerisque varius morbi enim nunc faucibus?",
            //             Answer = "Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices."
            //         },
            //         new FaqItemModel
            //         {
            //             Question = "Dolor sit amet consectetur adipiscing elit pellentesque?",
            //             Answer = "Eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci. Faucibus pulvinar elementum integer enim."
            //         },
            //         new FaqItemModel
            //         {
            //             Question = "Ac odio tempor orci dapibus. Aliquam eleifend mi in nulla?",
            //             Answer = "Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices."
            //         },
            //         new FaqItemModel
            //         {
            //             Question = "Tempus quam pellentesque nec nam aliquam sem et tortor?",
            //             Answer = "Molestie a iaculis at erat pellentesque adipiscing commodo. Dignissim suspendisse in est ante in."
            //         },
            //         new FaqItemModel
            //         {
            //             Question = "Perspiciatis quod quo quos nulla quo illum ullam?",
            //             Answer = "Enim ea facilis quaerat voluptas quidem et dolorem. Quis et consequatur non sed in suscipit sequi."
            //         }
            //     }
            // };

            TeamData = new TeamSectionModel
            {
                TeamMembers = new List<TeamMember>
                {
                    new TeamMember
                    {
                        Name = "Alex Leistra",
                        Description = "As a dedicated web developer, I specialize in creating innovative, user-friendly websites tailored to your unique vision. With a passion for design and a commitment to excellence, I ensure that every project is not only visually captivating but also optimized for performance and functionality. My mission is to deliver high-quality digital experiences that elevate your brand and engage your audience. Let's work together to bring your ideas to life!",
                        ImageUrl = "/bundle/img/team/alex.png",
                        SocialLinks = new List<SocialLink>
                        {
                            // new SocialLink { Url = "#", IconClass = "bi bi-twitter-x" },
                            // new SocialLink { Url = "#", IconClass = "bi bi-facebook" },
                            // new SocialLink { Url = "#", IconClass = "bi bi-instagram" },
                            new SocialLink { Url = "https://www.linkedin.com/in/alex-leistra-1032179a/", IconClass = "bi bi-linkedin" }
                        }
                    },
                    new TeamMember
                    {
                        Name = "Charb Cloud Solutions Inc.",
                        Description = "I specialize in providing Amazon Web Services (AWS) solutions for your business.",
                        SocialLinks = new List<SocialLink>
                        {
                            new SocialLink { Url = "https://www.charbcloud.com/", IconClass = "bi bi-box-arrow-up-right" }
                        }
                    },
                }
            };

            ContactData = new ContactSectionModel
            {
                ContactInfos = new List<ContactInfo>
                {
                    // new ContactInfo { Title = "Address", DetailLine1 = "A108 Adam Street", DetailLine2 = "New York, NY 535022", Icon = "bi bi-geo-alt" },
                    new ContactInfo { Title = "Text or Call Us", DetailLine1 = "(519)701-2014", DetailLine2 = "", Icon = "bi bi-telephone" },
                    new ContactInfo { Title = "Email Us", DetailLine1 = "alex@strongersoftworks.ca", DetailLine2 = "", Icon = "bi bi-envelope" },
                    //new ContactInfo { Title = "Open Hours", DetailLine1 = "Monday - Friday", DetailLine2 = "9:00AM - 05:00PM", Icon = "bi bi-clock" }
                }
            };


            base.OnParametersSet();
        }
    }
}
