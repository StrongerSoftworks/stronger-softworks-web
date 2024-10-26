namespace StrongerSoftworks.Web;

public interface IDomainProvider
{
    public string Domain { get; }
}

public class HttpRequestDomainProvider : IDomainProvider
{
    private IHttpContextAccessor _httpContextAccessor;

    public string Domain
    {
        get
        {
            return _httpContextAccessor.HttpContext.Request.Scheme +
            "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        }
    }

    public HttpRequestDomainProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

}

public class ConfigDomainProvider : IDomainProvider
{
    public string Domain
    {
        get
        {
            return Environment.GetEnvironmentVariable("HOST_URL") ?? "";
        }
    }
}