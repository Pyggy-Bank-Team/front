using IdentityServer4.AspNetIdentity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PiggyBank.IdentityServer.Models;

namespace PiggyBank.IdentityServer
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
            => _configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityServer()
               .AddInMemoryApiResources(Config.Apis)
               .AddInMemoryClients(Config.Clients)
               .AddDeveloperSigningCredential()
               .AddResourceOwnerValidator<ResourceOwnerPasswordValidator<IdentityUser>>();

            //UserManager
            services.AddDbContext<IndeintityContext>(opt =>
                    opt.UseSqlServer("Server=(local)\\SQL2016;Database=PiggyBank;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<IndeintityContext>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseIdentityServer();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
