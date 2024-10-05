namespace StrongerSoftworks.Web.Models;

public class Package
{
    public string Name { get; set; }
    public string SubTitle { get; set; }
    public float Price { get; set; }
    public float RecurringPrice { get; set; }
    public string Frequency { get; set; }
    public string CTA { get; set; }
    public List<string> Inclusions { get; set; }
}

public class AddOn
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public float RecurringPrice { get; set; }
    public string Frequency { get; set; }
    public List<AddOn> AddOns { get; set; }
}