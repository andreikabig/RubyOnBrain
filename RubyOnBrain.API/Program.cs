using Microsoft.EntityFrameworkCore;
using RubyOnBrain.Data;

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
// ��������� �������� DataContext � �������� ������� � ����������
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

app.MapGet("/", (DataContext db) => db.Entries.Include(t => t.Topic).ToList());


app.Run();
