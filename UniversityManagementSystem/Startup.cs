using BusinessLogic.Interfaces;
using BusinessLogic.Service;
using DataAccess.Models;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace UniversityManagementSystem
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
            services.AddDbContext<UMSContext>(options =>
                      options.UseSqlServer(Configuration.GetConnectionString("UMSConnection")));

            services.AddScoped<IRepository<Student>, RepositoryStudent>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IRepository<Course>, RepositoryCourse>();
            services.AddScoped<ICourseService, CourseService>();

            services.AddScoped<IRepository<Enrollment>, RepositoryEnrollment>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();

            services.AddScoped<IRepository<Teacher>, RepositoryTeacher>();
            services.AddScoped<ITeacherService, TeacherService>();

            services.AddScoped<IRepository<CourseTeacher>, RepositoryCourseTeacher>();
            services.AddScoped<ICourseTeacherService, CourseTeacherService>();

            services.AddScoped<IRepository<Office>, RepositoryOffice>();
            services.AddScoped<IOfficeService, OfficeService>();

            services.AddControllers().AddJsonOptions(x =>
                                      x.JsonSerializerOptions.ReferenceHandler  = ReferenceHandler.Preserve);
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
