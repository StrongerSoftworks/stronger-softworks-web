using AspNetStatic;
using AspNetStaticContrib.AspNetStatic;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.StaticFiles;
using StrongerSoftworks.Web;
using StrongerSoftworks.Web.Components;
using StrongerSoftworks.Web.Helpers;
using System.Globalization;


const string RUN_MODE_SSG = "ssg";
const string SSG_DEST_ROOT_FOLDER_NAME = "out";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

Console.WriteLine(builder.Environment.IsDevelopment());
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddResponseCompression(options =>
    {
        options.Providers.Add<BrotliCompressionProvider>();
        options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
            [
                "application/octet-stream",
                "text/javascript",
                "text/css"
            ]);
    });
}

string runMode = Environment.GetEnvironmentVariable("RUN_MODE") ?? "ssr";

if (runMode == RUN_MODE_SSG) {
    builder.Services.AddSingleton<IStaticResourcesInfoProvider>(provider =>
    {
        return StaticWebSiteHelper.GetStaticResourcesInfo(builder.Environment.WebRootPath);
    });
    builder.Services.AddScoped<IDomainProvider, ConfigDomainProvider>();
} else {
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddScoped<IDomainProvider, HttpRequestDomainProvider>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseResponseCompression();
}

// ContentType mappings
var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".avif"] = "image/avif";

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        // Cache static files for 1 year
        ctx.Context.Response.Headers.Append("Cache-Control", "public,max-age=31536000");
        ctx.Context.Response.Headers.Append("Expires", DateTime.UtcNow.AddDays(60).ToString("R", CultureInfo.InvariantCulture));
    },
    ContentTypeProvider = provider
});
app.UseAntiforgery();

app.MapRazorComponents<App>();

if (runMode == RUN_MODE_SSG) {
    var SsgOutputPath = Path.Combine(
        "../../", SSG_DEST_ROOT_FOLDER_NAME);

    Directory.CreateDirectory(SsgOutputPath);

    app.GenerateStaticContent(
        SsgOutputPath,
        exitWhenDone: true);
}

app.Run();
