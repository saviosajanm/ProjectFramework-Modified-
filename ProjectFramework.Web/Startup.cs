using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectFramework.Web.BLL;
using ProjectFrameworkCommonLib;

namespace ProjectFramework.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // Use AddControllersWithViews for MVC support
            services.AddRazorPages();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Standard session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            string appConnectionString = Configuration.GetConnectionString("PFConnStr");
            Utils.DatabaseUtils.SetConnectionString(appConnectionString);
            string encryptionDecryptionKey = Configuration.GetValue<string>("PFEncryptDecryptKey");

            if (string.IsNullOrEmpty(encryptionDecryptionKey))
            {
                encryptionDecryptionKey = "KtsInfotechPalaKeralaIndia";
            }

            PFCrypt.Key = encryptionDecryptionKey;

            // Load mobile auth settings at startup
            SetAuthenticationTokenOptions();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string baseDir = env.ContentRootPath;
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(baseDir, "App_Data"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                // MODIFICATION: Ensure API controllers are mapped first.
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

        private void SetAuthenticationTokenOptions()
        {
            try
            {
                SettingsBLL settingsBLLObj = new SettingsBLL();
                string result = settingsBLLObj.GetValue("EnableMobAuth");
                if (result.ToLower() == "true")
                {
                    SettingsBLL.SetAuthToken(true);
                }
                else
                {
                    SettingsBLL.SetAuthToken(false);
                }
            }
            catch (Exception)
            {
                SettingsBLL.SetAuthToken(false);
            }
        }
    }
}