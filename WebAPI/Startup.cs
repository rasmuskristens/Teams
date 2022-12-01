using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
using WebAPI.Model.DisccusionFolder;
using WebAPI.Model.MembershipFolder;
using WebAPI.Model.PollFolder;
using WebAPI.Model.TeamFolder;
//using WebAPI.DataAccess;

namespace WebAPI
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
            services.AddControllers();
            services.AddScoped<IUser, User>();
            services.AddScoped<ITeamContext, TeamContext>();
            services.AddScoped<IDiscussionContext, DisccusionsContext>();
            services.AddScoped<IPollContext,PollContext>();
            services.AddScoped<IMembershipContext, MembershipContext>();
            services.AddDbContext<DatabaseContext>(options =>
            {
                // options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                Console.WriteLine("getting to the breakpoint");
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // SQLite
            // services.AddDbContext<DatabaseContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


    }
}
