using HRM.Connection;
using HRM.Context;
using HRM.Forms;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace HRM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(ConnectionManager.ConnectionString))
                .AddTransient<MainMenu>()
                .BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<MainMenu>();
           

            Application.Run(mainForm);
        }
    }
}