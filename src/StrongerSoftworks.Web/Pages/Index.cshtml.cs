using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrongerSoftworks.Web.Models;

namespace StrongerSoftworks.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Package> Packages;
    public List<AddOn> AddOns;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Packages = new List<Package>() {
            new Package() {
                Name = "1 Page",
                SubTitle = "Perfect for Small and New Businesses",
                Price = 500f,
                RecurringPrice = 5f,
                Frequency = "month",
                CTA = "Sign Up for Free",
                Inclusions = new List<string>() {
                    "1 Page Website",
                    "Hosting in Canada",
                    "Free SSL",
                    "Free CDN",
                    "Web Application Firewall",
                    "DDos Protection"
                }
            }
        };
        AddOns = new List<AddOn>() {
            new AddOn() { Name = "Additional Pages", Price = 100, Frequency = "Page" },
            new AddOn() { Name = "Google Integration", Price = 100, AddOns = new List<AddOn> {
                new AddOn() { Name = "Google Maps" },
                new AddOn() { Name = "Google Tag Manager" },
                new AddOn() { Name = "Google Analytics" },
                new AddOn() { Name = "Google Concent Mode with Cookie Banner" },
            } },
            new AddOn() {
                Name = "Content Management System Integration",
                Description = "Strapi CMS built for you pages managed by us.",
                Price = 200,
                Frequency = "Page",
                AddOns = new List<AddOn>() {
                    new AddOn() { Name = "10GB Storage, 10 Users", RecurringPrice = 10, Frequency = "Month" },
                    new AddOn() { Name = "50GB Storage, 20 Users", RecurringPrice = 20, Frequency = "Month" },
                    new AddOn() { Name = "100GB Storage, 50 Users", RecurringPrice = 30, Frequency = "Month" },
                }
            },
        };
    }

    public void OnGet()
    {

    }
}
