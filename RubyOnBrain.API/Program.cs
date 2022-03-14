using Microsoft.EntityFrameworkCore;
using RubyOnBrain.Data;

var builder = WebApplication.CreateBuilder(args);

// Получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// Добавляем контекст DataContext в качестве сервиса в приложение
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

app.MapGet("/", (DataContext db) => db.Entries.Include(t => t.Topic).ToList());


app.Run();
