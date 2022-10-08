using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
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
            services.AddDbContext<DatabaseContext>(options =>
            {
                // options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                Console.WriteLine("getting to the breakpoint");
                options.UseSqlServer(Configuration.GetConnectionString("Server=tcp:systematic.database.windows.net,1433;Initial Catalog=TeamsDatabase;Persist Security Info=False;User ID=CloudSA8a746401;Password=Qyn76urj;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
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
