using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer.Interfaces;
using Data_Layer.Models;
using Data_Layer;
using Business_Layer;
using Business_Layer.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SI2021_CoffeeMachineApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var magacinApp = serviceProvider.GetRequiredService<Pocetna>();
                Application.Run(magacinApp);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IMagacinRepository, MagacinRepository>();
            services.AddTransient<IBusinessRepository, BusinessRepository>();
            services.AddTransient<Pocetna>(); 
        }
    }
}
