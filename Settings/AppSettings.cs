using Microsoft.Extensions.Configuration;
using System.IO;

namespace FileContentSeek.Settings
{
    public static class AppSettings
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static string OpenWith;
        public static string DefaultDir;

        public static void Save()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            Configuration["Config:OpenWith"] = AppSettings.OpenWith;
            Configuration["Config:DefaultDir"] = AppSettings.DefaultDir;
        }
    }
}
