using System.Net;
using System.Text.RegularExpressions;
using AspNetStatic;

namespace StrongerSoftworks.Web.Helpers;


public static class StaticWebSiteHelper
{
    private static readonly string staticAssetExtensions = @"^\.(jpe?g|gif|png|avif|woff|woff2|ttf|)$";



    /// <summary>
    /// <see cref="StaticResourcesInfoProvider"/>
    /// </summary>
    /// <returns><see cref="StaticResourcesInfoProvider"/></returns>
    public static StaticResourcesInfoProvider GetStaticResourcesInfo(string webRootPath)
    {
        string[] excludedFiles = [];
        string[] excludedFolders= [];

        List<ResourceInfoBase> pages = new(2000)
        {
            new PageResource("/"),
        };

        DirectoryInfo wwwRootDirectory = new(webRootPath);

        List<ResourceInfoBase> wwwRootPages = GetPageInfoFromDirectory(wwwRootDirectory, "/", excludedFolders, excludedFiles);
        pages.AddRange(wwwRootPages);

        StaticResourcesInfoProvider provider = new(pages);
        return provider;
    }

    private static List<ResourceInfoBase> GetPageInfoFromDirectory(DirectoryInfo baseDirectory, string baseUri, IEnumerable<string>? excludedFolderName, IEnumerable<string>? excludedFileName)
    {
        excludedFolderName ??= ["node_modules", "assets"];
        excludedFileName ??= [];


        List<ResourceInfoBase> pages = new(100);

        foreach (FileInfo file in baseDirectory.EnumerateFiles().Where(fileInfo => !excludedFileName.Contains(fileInfo.Name)))
        {
            string name = file.Name;
            string extension = file.Extension;

            if (name.Equals("README.md", StringComparison.OrdinalIgnoreCase))
            {
                pages.Add(new PageResource(baseUri)
                {
                    OutFile = Path.Combine(baseUri, "index.html")
                });
            }
            else if (extension.Equals(".js", StringComparison.OrdinalIgnoreCase))
            {
                pages.Add(new JsResource(Path.Combine(baseUri, name).Replace('\\', '/')));
            }
            else if (extension.Equals(".css", StringComparison.OrdinalIgnoreCase))
            {
                pages.Add(new CssResource(Path.Combine(baseUri, name).Replace('\\', '/')));
            }
            else if (Regex.IsMatch(extension, staticAssetExtensions, RegexOptions.IgnoreCase))
            {
                pages.Add(new BinResource(Path.Combine(baseUri, name).Replace('\\', '/')));
            }
        }

        foreach (DirectoryInfo directory in baseDirectory.EnumerateDirectories().Where(dirInfo => !excludedFolderName.Contains(dirInfo.Name)))
        {
            List<ResourceInfoBase> infos = GetPageInfoFromDirectory(directory, Path.Combine(baseUri, directory.Name).Replace('\\', '/'), null, null);
            pages.AddRange(infos);
        }

        return pages;
    }
}