using App.Application;
using App.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
// using Microsoft.Identity.Web; // not used
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
string _EntityConnectionString = ConfigurationExtensions.GetConnectionString(builder.Configuration, "DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
string _IdentityConnectionString = ConfigurationExtensions.GetConnectionString(builder.Configuration, "IdentityConnection") ?? throw new InvalidOperationException("Connection string 'ScriptatIdentityContextConnection' not found.");

//builder.Services.AddSingleton<IAppSettings, AppSettings>();
builder.Services.AddDbContext<ScriptatDBContext>(options => options.UseSqlServer(_IdentityConnectionString));
builder.Services.AddDbContext<ScriptatIdentityContext>(options => options.UseSqlServer(_IdentityConnectionString));

ServiceCollectionServiceExtensions.AddScoped<ICoreHelper, CoreHelper>(builder.Services);
ServiceCollectionServiceExtensions.AddScoped<IUserManagement, UserManagement>(builder.Services);
ServiceCollectionServiceExtensions.AddScoped<IProjectRepository, ProjectRepository>(builder.Services);
//ServiceCollectionServiceExtensions.AddScoped<IProjectPartRepository, ProjectPartRepository>(builder.Services);
//ServiceCollectionServiceExtensions.AddScoped<IComponentRepository, ComponentRepository>(builder.Services);

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
{
    opt.Password.RequiredLength = 6;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireDigit = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<ScriptatIdentityContext>()
.AddSignInManager<SignInManager<ApplicationUser>>()
.AddDefaultTokenProviders();
// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["keyjwt"])),
        ClockSkew = TimeSpan.Zero
    };
});

//.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"))
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UserTokenService>();
builder.Services.AddScoped<UserManagement>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var uploadsPath = Path.Combine(app.Environment.ContentRootPath, "uploads");
Directory.CreateDirectory(uploadsPath); // no-op if it exists

app.UseStaticFiles(); // serves wwwroot

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(uploadsPath),
    RequestPath = "/uploads"
});

app.UseRouting();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
