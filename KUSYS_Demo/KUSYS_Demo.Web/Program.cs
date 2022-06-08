using KUSYS_Demo.Business.Abstract;
using KUSYS_Demo.Business.Concrete;
using KUSYS_Demo.DataAccess;
using KUSYS_Demo.DataAccess.Abstract;
using KUSYS_Demo.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

//Database
string cs = "server=localhost; database=KusysDemoDB; integrated security=true;";
builder.Services.AddDbContext<Context>(op => op.UseSqlServer(cs));
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers(options => options.EnableEndpointRouting = false);

builder.Services.AddScoped<IStudentBusiness, StudentsBusiness>();
builder.Services.AddScoped<IStudentRepositroy, StudentRepository>();
builder.Services.AddScoped<IStudentCourseBusiness, StudentCourseBusiness>();
builder.Services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
builder.Services.AddScoped<ICourseBusiness, CourseBusiness>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//string cs = "server=localhost; database=KusysDemoDB; integrated security=true;";
//builder.Services.AddDbContext<Context>(op => op.UseSqlServer(cs));
//builder.Services.AddHttpContextAccessor();

////builder.Services.AddControllers(options => options.EnableEndpointRouting = false);

//builder.Services.AddSingleton<IStudentBusiness, StudentsBusiness>();
////builder.Services.AddSingleton<IStudentRepositroy, StudentRepository>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
