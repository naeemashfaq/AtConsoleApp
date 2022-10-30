using AtConsoleApp.DataContext;
using AtConsoleApp.Handler;
using AtConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new HostBuilder()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<ApplicationHandler>()
            .AddSingleton<IEmployeeService, EmployeeService>()
            .AddDbContext<EmployeeContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=Employee;Trusted_Connection=True;MultipleActiveResultSets=true");
            });
    }).UseConsoleLifetime();

var host = builder.Build();
var app = host.Services.GetRequiredService<ApplicationHandler>();
app.Run();