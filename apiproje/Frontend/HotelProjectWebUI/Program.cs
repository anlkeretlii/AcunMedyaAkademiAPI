using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
builder.Services.AddControllersWithViews();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddAutoMapper(typeof(Program));

// Geliştirme aşamasında authorization devre dışı
// builder.Services.AddMvc(config =>
// {
//     var policy = new AuthorizationPolicyBuilder()
//     .RequireAuthenticatedUser()
//     .Build();
//     config.Filters.Add(new AuthorizeFilter(policy));
// });

// Geliştirme aşamasında cookie authentication devre dışı
// builder.Services.ConfigureApplicationCookie(options =>
// {
//     options.Cookie.HttpOnly = true;
//     options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
//     options.LoginPath = "/Login/Index/";
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
// app.UseAuthentication(); // Geliştirme için kapalı
app.UseRouting();
// app.UseAuthorization(); // Geliştirme için kapalı

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//dotnet run --project ApiConsume/HotelProjectWebApi