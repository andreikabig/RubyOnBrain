using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using RubyOnBrain.Data;
using RubyOnBrain.Domain;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// ������ ����������� � ��
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� ������������ DataContext 
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// GET ������ ������
app.Run(async (context) =>
    {
        string path = context.Request.Path;
        var db = context.RequestServices.GetService<DataContext>();
        var queryString = context.Request.QueryString;
        string msg = "������������ ������";

        if (path == "/courses" && !String.IsNullOrEmpty(context.Request.Query["page"]) && !String.IsNullOrEmpty(context.Request.Query["pagesize"]))
        {
            // �������������� ���-�� �������, ������ ��������
            int page, pageSize;



            // ���� � ������� ���������� ������ ������
            if (Int32.TryParse(context.Request.Query["page"], out page) && Int32.TryParse(context.Request.Query["pagesize"], out pageSize))
            {

                // ��������� ���-�� ��������� ������
                int? quantity = db?.Courses.Count();

                // ���-�� ��������� �� ��������� ��������
                int lastItemsCount = Convert.ToInt32(quantity % pageSize);
                // ����� ��������� ��������
                int lastPage = Convert.ToInt32(Math.Ceiling((decimal)quantity / (decimal)pageSize)); // ���� �� 1 ������

                // ����������������, ����� ������ ������� �� pageSize ���������
                int ps = pageSize;
                // ���� ��������� ��������
                if (page == lastPage)
                    ps = lastItemsCount;    // ������� = ���-�� ��������� �� ��������� ��������


                if (page <= lastPage && page >= 1)
                {
                    // ������� �������
                    var courses = db?.Courses.ToList().GetRange(pageSize * (page - 1), ps);
                    // ���������� ������� �������
                    await context.Response.WriteAsJsonAsync(courses);
                }
                else
                    msg = "����� �������� �� ����������!";
            }

            await context.Response.WriteAsJsonAsync(new { msg = msg });
        }
        else if (path == "/courses/all" && context.Request.Method == "GET")
        {
            await context.Response.WriteAsJsonAsync(db?.Courses.ToList());
        }
        else if (path == "/courses" && context.Request.Method == "POST")
        {
            if (context.Request.HasJsonContentType())
            {
                Course? course = await context.Request.ReadFromJsonAsync<Course>();

                if (course != null && !db.Courses.Any(c => c.Name == course.Name))
                {
                    db.Courses.Add(course);
                    db.SaveChanges();
                    msg = "�������� ���������� �����!";
                    context.Response.StatusCode = 200;
                }
                else
                {
                    context.Response.StatusCode = 400;
                    msg = "���� � ����� ��������� ��� ����������!";
                }

                await context.Response.WriteAsJsonAsync(new { msg = msg });
            }
        }
        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "GET")
        {
            int id;

            if (Int32.TryParse(path.Split("/")[^1], out id))
            {
                var course = db.Courses.FirstOrDefault(c => c.Id == id);
                if (course != null)
                    await context.Response.WriteAsJsonAsync(course);
                else
                    await context.Response.WriteAsJsonAsync(new { msg = "������ ����� �� ����������!" });
            }
        }
        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "PUT")
        {
            if (context.Request.HasJsonContentType())
            { 
                var newCourse = await context.Request.ReadFromJsonAsync<Course>();

                if (newCourse != null)
                {
                    var course = db.Courses.FirstOrDefault(c => c.Id == newCourse.Id);

                    if (course != null)
                    {
                        course.ProgLang = newCourse.ProgLang;
                        course.Name = newCourse.Name;
                        db.SaveChanges();
                    }
                }
            }
            
        }
        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "DELETE")
        {
            int id;

            if (Int32.TryParse(path.Split("/")[^1], out id))
            {
                var course = db.Courses.FirstOrDefault(c => c.Id == id);
                if (course != null)
                    db.Courses.Remove(course);
            }
        }
    }
);


// GET ������ �������

// GET ������ �������

// POST ����

// POST �����

// POST �����

// DELETE ����

// DELETE �����

// DELETE �����

// UPDATE ����

// UPDATE �����

// UPDATE �����



app.Run();


