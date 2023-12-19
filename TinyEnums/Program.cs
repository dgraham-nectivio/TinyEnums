using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TinyEnums;

var connectionString = new SqlConnectionStringBuilder
{
    DataSource = "localhost",
    InitialCatalog = "tiny",
}.ToString();

var services = new ServiceCollection();

services.AddDbContext<TinyContext>(opt => opt.UseSqlServer(connectionString));

var provider = services.BuildServiceProvider();

var context = provider.GetRequiredService<TinyContext>();

context.Database.EnsureCreated();

var dataType = context.Model.FindEntityType(typeof(Thing))?
    .FindProperty(nameof(Thing.TinyEnum))?
    .GetColumnType();

Console.WriteLine($"The column type for Thing.TinyEnum is: {dataType}");