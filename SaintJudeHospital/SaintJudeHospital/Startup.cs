using System.Linq;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SaintJudeHospital.Data.Entity;
using SaintJudeHospital.Data.Indentity;
using SaintJudeHospital.Data.Seed;
using SaintJudeHospital.Mediators;
using SaintJudeHospital.Services;

namespace SaintJudeHospital
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            BuildMediator(services);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("SaintJudeHospital")));

            services
                .AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = "https://localhost:44363",
                    ValidIssuer = "https://localhost:44363",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SaintJudeSecurityKey"))
                };
            });

            BuildDataServices(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            AppDbContextInitializer.LoadApplicationUser(app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope()
                .ServiceProvider);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static IMediator BuildMediator(IServiceCollection services)
        {
            services.AddScoped<ServiceFactory>(p => p.GetService);

            services.Scan(scan => scan
                .FromAssembliesOf(typeof(IMediator),
                    typeof(IMediatorHandler))
                .AddClasses()
                .AsImplementedInterfaces());

            var provider = services.BuildServiceProvider();

            return provider.GetRequiredService<IMediator>();
        }

        private static void BuildDataServices(IServiceCollection services)
        {
            services.Scan(scan => scan
                            .FromAssembliesOf(typeof(IService))
                            .AddClasses()
                            .AsImplementedInterfaces());

            var provider = services.BuildServiceProvider();

            provider.GetRequiredService<IService>();
        }

    }
}
