using CloudManifestServices.Areas.Identity;
using CloudManifestServices.Data;
using CloudManifestServices.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using CloudManifestServices.Interfaces;
using CloudManifestServices.ImplementationClasses;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<ProvokeDBContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("MetricsConnection")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = false; });
builder.Services.AddScoped<IServices, ServicesImplementationClass>();
builder.Services.AddScoped<IIncident, IncidentImplementationClass>();
builder.Services.AddScoped<ISource, SourceImplementationClass>();
builder.Services.AddScoped<IDashboardIcm, DashboardIcmImplementationClass>();
builder.Services.AddScoped<IManifestManagement, ManifestManagementImplementationClass>();
builder.Services.AddScoped<IChangeLogHistorical, ChangeLogHistoricalImplementationClass>();
builder.Services.AddScoped<IProcessControl, ProcessImplementationClass>();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkWFpGaV1HQmFJfFBmTWldf1RyfUU3HVdTRHRcQlxhT35bckNhUHpbeHw=;Mgo+DSMBPh8sVXJ0S0J+XE9AclRAQmFMYVF2R2BJd1R0dF9EaUwgOX1dQl9gSX9RcEVrXXlceXFSRGg=;ORg4AjUWIQA/Gnt2VVhkQlFacltJX3xLe0x0RWFab1Z6cFVMYlVBNQtUQF1hSn5SdENjUXtYcn1QTmdU;MTAwOTgzM0AzMjMwMmUzNDJlMzBrenBxQWRPODc2ZlBadnYrQjBJOUVOUzIvOEt3REJCcnFVY05lWURxVGV3PQ==;MTAwOTgzNEAzMjMwMmUzNDJlMzBTM3RzdThaVjhicDhhMnpFSHpKeTZackNUckpWRU54dmhVc0NxNWwzKzg0PQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtGVmFWfFZpR2NbfE54flFGal5YVAciSV9jS31Td0dlWXdadnZcQGVfWQ==;MTAwOTgzNkAzMjMwMmUzNDJlMzBtcm52OXlXS1ZacmJJdEdUTzgyU1NTNUF2a3B5WWhtbWZWdUZod1puVXdvPQ==;MTAwOTgzN0AzMjMwMmUzNDJlMzBSdTM4SHU5b09aWUJZNG1xMkNvK3ZLQjhUUDU5VWJ4ZDZndVVUTmVPYVhjPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacltJX3xLe0x0RWFab1Z6cFVMYlVBNQtUQF1hSn5SdENjUXtYcn1SR2dc;MTAwOTgzOUAzMjMwMmUzNDJlMzBVTGVVak1LbDhSUG5abXBJd1djVEYyaEJZMUxUTFB6U2wyTGlTRE1mMDNJPQ==;MTAwOTg0MEAzMjMwMmUzNDJlMzBOczUvMERIVys0YkJwWWNnWmlXZzhHcS9TdEt2TmNCN2hLUGExUWVWanM4PQ==;MTAwOTg0MUAzMjMwMmUzNDJlMzBtcm52OXlXS1ZacmJJdEdUTzgyU1NTNUF2a3B5WWhtbWZWdUZod1puVXdvPQ==");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
