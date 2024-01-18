using ConsoleApp.Contexts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;



var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\projects\EFC\ConsoleApp\Data\local_database.mdf;Integrated Security=True;Connect Timeout=30"));
})
.Build();
