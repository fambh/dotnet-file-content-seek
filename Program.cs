using FileContentSeek.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileContentSeek
{
    static class Program
    {   
        public static IConfigurationRoot Configuration { get; set; }

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            AppSettings.OpenWith = Configuration["Config:OpenWith"];
            AppSettings.DefaultDir = Configuration["Config:DefaultDir"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContentSeekForm());
        }
    }
}
