using System;
using System.Net.Http;
using System.Threading.Tasks;
using Funtik.Interfaces;
using Funtik.Models;
using Funtik.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Funtik
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient<IAccountModel, AccountModel>();
            builder.Services.AddTransient<IIdentityService, PiggyBankService>();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
           
            await builder.Build().RunAsync();
        }
    }
}
