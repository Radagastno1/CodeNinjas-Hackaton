var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddDbContext<Core.Data.TrananDbContext>(
//     options =>
//         options.UseSqlite(
//             "Data Source=INFRASTRUCTURE/Data/DbContext"
//         )
// );

builder.Services.AddScoped<
    CORE.Interfaces.Iservice<CORE.Entities.User>,CORE.Services.UserService
>();
// builder.Services.AddScoped<
//     CORE.Interfaces.Iservice<CORE.Entities.Challenge>,CORE.Services.ChallengeService
// >();
// builder.Services.AddScoped<
//     CORE.Interfaces.Iservice<CORE.Entities.Track>,CORE.Services.TrackService
// >();

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
