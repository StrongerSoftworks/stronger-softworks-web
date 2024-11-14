using Sidio.Sitemap.Core;

namespace StrongerSoftworks.Web.Helpers;

public class BaseUrlProvider : IBaseUrlProvider
{

    private readonly IHttpContextAccessor _httpContextAccessor;

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpContextBaseUrlProvider"/> class.
    /// </summary>
    /// <param name="httpContextAccessor"></param>
    public BaseUrlProvider(IHttpContextAccessor httpContextAccessor)
    {
        ArgumentNullException.ThrowIfNull(httpContextAccessor);
        _httpContextAccessor = httpContextAccessor;
    }

    /// <inheritdoc />
    public Uri BaseUrl
    {
        get
        {
            string? baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
            if (baseUrl == null)
            {
                var request = _httpContextAccessor.HttpContext?.Request ?? throw new InvalidOperationException("The HTTP context is not available.");
                return new($"{request.Scheme}://{request.Host.Value}{request.PathBase}", UriKind.Absolute);
            }
            else
            {
                return new Uri(baseUrl);
            }
        }
    }
}