using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using InteriorMobilya.WebUI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using InteriorMobilya.Service.Concrete;
using InteriorMobilya.Service.Abstract;
using InteriorMobilya.DataAccess.Concrete.EF;
using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.WebUI.Services.Concrete;
using InteriorMobilya.WebUI.Services.Abstract;

namespace InteriorMobilya.WebUI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProduct, EFProduct>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategory, EFCategory>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomer, EFCustomer>();
            services.AddScoped<ICustomerAdressService, CustomerAdressService>();
            services.AddScoped<ICustomerAdress, EFCustomerAdress>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountry, EFCountry>();
            services.AddScoped<ICity, EFCity>();
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrder, EFOrder>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderDetail, EFOrderDetail>();

            services.AddScoped<IOrderStatusService, OrderStatusService>();
            services.AddScoped<IOrderStatus, EFOrderStatus>();
            services.AddScoped<IPaymentTypeService, PaymentTypeService>();
            services.AddScoped<IPaymentType, EFPaymentType>();

            services.AddSingleton<IShoppingCartUserService, ShoppingCartUserService>();
            services.AddSingleton<IShoppingCartService, ShoppingCartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<CustomIdentityDbContext>
              (options => options.UseSqlServer("Server=.;Database=InteriorMobilyaDB;Integrated Security=true"));

            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext,Guid>()
                .AddDefaultTokenProviders();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                

                //cookie setting
                options.Cookies.ApplicationCookie.LoginPath = new PathString("/giris");
                options.Cookies.ApplicationCookie.LogoutPath = new PathString("/cikis");
                options.Cookies.ApplicationCookie.ReturnUrlParameter = "returnurl";

                //user
                options.User.RequireUniqueEmail = true;
            });
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
 
            app.UseStaticFiles();
            app.UseSession();
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
               
            });
        }
    }
}
