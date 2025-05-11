using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Data;

namespace WinFormsApp1;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>();

                services.AddScoped<FormOrder>();
                services.AddScoped<DeveloperReportForm>(provider =>
                {
                    var db = provider.GetService<AppDbContext>();
                    return new DeveloperReportForm(db);
                }); 
            })
            .Build();

        var formOrder = host.Services.GetService<FormOrder>();
        var developerReportForm = host.Services.GetService<DeveloperReportForm>();
        
        formOrder.Show();
        Application.Run(developerReportForm);
    }
}