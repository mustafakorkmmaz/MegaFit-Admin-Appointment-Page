using MegaFit.Business.CustomerAssessmentManagers;
using MegaFit.Business.CustomerDetailsManagers;
using MegaFit.Business.CustomerHistoryManagers;
using MegaFit.Business.CustomerManagers;
using MegaFit.Business.DealAppointmentManagers;
using MegaFit.Business.TherapyPackagesManagers;
using MegaFit.Business.AppointmentHourManagers;
using MegaFit.DataAccess;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
Trace.Listeners.Add(new TextWriterTraceListener("error-logs.txt"));
Trace.AutoFlush = true;
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MegaContext>();
builder.Services.AddTransient<ICustomerService,CustomerService>();
builder.Services.AddTransient<ICustomerVisitService,CustomerVisitService>();
builder.Services.AddTransient<ICustomerAssessmentService, CustomerAssessmentService>();
builder.Services.AddTransient<IPackageService, PackageService>();
builder.Services.AddTransient<IDealService, DealService>();
builder.Services.AddTransient<IAppointmentHourService, AppointmentHourService>();


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
