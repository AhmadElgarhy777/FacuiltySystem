using DataAccess;
using Microsoft.EntityFrameworkCore;

using System;
using Microsoft.AspNetCore.Identity;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;

namespace GraduationProject__FacuiltySystem__
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<ApplicationDbContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
               );

            //builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            //builder.Services.AddScoped<IStudentPhoneRepository, StudentPhoneRepository>();
            //builder.Services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();

            //builder.Services.AddScoped<IMemberRepository, MemberRepository>();
            //builder.Services.AddScoped<IMemberPhoneRepository, MemberPhoneRepository>();

            //builder.Services.AddScoped<ICourseRepository, CourseRepository>();

            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.MapRazorPages();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
