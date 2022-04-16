using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using RubyOnBrain.API;
using RubyOnBrain.Data;
using RubyOnBrain.Domain;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// ������ ����������� � ��
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� ������������ DataContext 
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

//builder.Services.AddDbContextFactory<DataContext>();


var app = builder.Build();



// ���������� ����� �������� ����� ���������

app.MapGet("/courses", async (HttpContext context, DataContext db) =>
{
    string path = context.Request.Path;

    string msg = "������������ ������";

    if (!String.IsNullOrEmpty(context.Request.Query["page"]) && !String.IsNullOrEmpty(context.Request.Query["pagesize"]))
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
    await context.Response.WriteAsJsonAsync(new { msg = msg });
});

app.MapPost("/courses", async (HttpContext context, DataContext db, Course course) => {
    string msg = "������������ ������!";
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
});

app.MapGet("/courses/all", (DataContext db) => Results.Json(db?.Courses.ToList()));

app.MapGet("/courses/{id:int}", async (HttpContext context, DataContext db, int id) => {
    var course = db.Courses.FirstOrDefault(c => c.Id == id);
    if (course != null)
        await context.Response.WriteAsJsonAsync(course);
    else
        await context.Response.WriteAsJsonAsync(new { msg = "������ ����� �� ����������!" });
});

app.MapPut("/courses/{id:int}", async (HttpContext context, DataContext db, int id) => {
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
});

app.MapDelete("/courses/{id:int}", async (HttpContext context, DataContext db, int id) => {
    var course = db.Courses.FirstOrDefault(c => c.Id == id);
    if (course != null)
        db.Courses.Remove(course);
});

app.MapGet("/courses/rating", (DataContext db) => Results.Json(db?.UserCourses.ToList()));

app.MapGet("/api/login", async (HttpContext context, DataContext db) => {
    string path = context.Request.Path;

    bool access = false;

    if (!String.IsNullOrEmpty(context.Request.Query["login"]) && !String.IsNullOrEmpty(context.Request.Query["password"]))
    {
        var user = db.Users.FirstOrDefault(x => x.Email == Convert.ToString(context.Request.Query["login"]) && x.Password == Convert.ToString(context.Request.Query["password"]));

        if (user != null)
            access = true;
    }

    return access;
});

app.MapPost("/api/uploadfiles/recsys", async (HttpContext context) => {
    var files = context.Request.Form.Files;

    var uploadPath = $"{Directory.GetCurrentDirectory()}/Uploads/Data/recsys";

    if (!Directory.Exists(uploadPath))
        Directory.CreateDirectory(uploadPath);

    foreach (var file in files)
    {

        string fullPath = $"{uploadPath}/{file.FileName}";


        using (var fileStram = new FileStream(fullPath, FileMode.Create))
        {
            await file.CopyToAsync(fileStram);  
        }
    }

    await context.Response.WriteAsJsonAsync(new { msg = "���� ������� ��������!" });
});


// ���������� ����� ������������ MiddleWare

// GET ������ ������
//app.Run(async (context) =>
//    {
//        string path = context.Request.Path;
//        var db = context.RequestServices.GetService<DataContext>();
//        var queryString = context.Request.QueryString;
//        string msg = "������������ ������";

//        if (path == "/courses" && !String.IsNullOrEmpty(context.Request.Query["page"]) && !String.IsNullOrEmpty(context.Request.Query["pagesize"]))
//        {
//            // �������������� ���-�� �������, ������ ��������
//            int page, pageSize;



//            // ���� � ������� ���������� ������ ������
//            if (Int32.TryParse(context.Request.Query["page"], out page) && Int32.TryParse(context.Request.Query["pagesize"], out pageSize))
//            {

//                // ��������� ���-�� ��������� ������
//                int? quantity = db?.Courses.Count();

//                // ���-�� ��������� �� ��������� ��������
//                int lastItemsCount = Convert.ToInt32(quantity % pageSize);
//                // ����� ��������� ��������
//                int lastPage = Convert.ToInt32(Math.Ceiling((decimal)quantity / (decimal)pageSize)); // ���� �� 1 ������

//                // ����������������, ����� ������ ������� �� pageSize ���������
//                int ps = pageSize;
//                // ���� ��������� ��������
//                if (page == lastPage)
//                    ps = lastItemsCount;    // ������� = ���-�� ��������� �� ��������� ��������


//                if (page <= lastPage && page >= 1)
//                {
//                    // ������� �������
//                    var courses = db?.Courses.ToList().GetRange(pageSize * (page - 1), ps);
//                    // ���������� ������� �������
//                    await context.Response.WriteAsJsonAsync(courses);
//                }
//                else
//                    msg = "����� �������� �� ����������!";
//            }

//            await context.Response.WriteAsJsonAsync(new { msg = msg });
//        }
//        else if (path == "/courses/all" && context.Request.Method == "GET")
//        {
//            await context.Response.WriteAsJsonAsync(db?.Courses.ToList());
//        }
//        else if (path == "/courses" && context.Request.Method == "POST")
//        {
//            if (context.Request.HasJsonContentType())
//            {
//                Course? course = await context.Request.ReadFromJsonAsync<Course>();

//                if (course != null && !db.Courses.Any(c => c.Name == course.Name))
//                {
//                    db.Courses.Add(course);
//                    db.SaveChanges();
//                    msg = "�������� ���������� �����!";
//                    context.Response.StatusCode = 200;
//                }
//                else
//                {
//                    context.Response.StatusCode = 400;
//                    msg = "���� � ����� ��������� ��� ����������!";
//                }

//                await context.Response.WriteAsJsonAsync(new { msg = msg });
//            }
//        }
//        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "GET")
//        {
//            int id;

//            if (Int32.TryParse(path.Split("/")[^1], out id))
//            {
//                var course = db.Courses.FirstOrDefault(c => c.Id == id);
//                if (course != null)
//                    await context.Response.WriteAsJsonAsync(course);
//                else
//                    await context.Response.WriteAsJsonAsync(new { msg = "������ ����� �� ����������!" });
//            }
//        }
//        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "PUT")
//        {
//            if (context.Request.HasJsonContentType())
//            {
//                var newCourse = await context.Request.ReadFromJsonAsync<Course>();

//                if (newCourse != null)
//                {
//                    var course = db.Courses.FirstOrDefault(c => c.Id == newCourse.Id);

//                    if (course != null)
//                    {
//                        course.ProgLang = newCourse.ProgLang;
//                        course.Name = newCourse.Name;
//                        db.SaveChanges();
//                    }
//                }
//            }

//        }
//        else if (Regex.IsMatch(path, @"^/courses/\d+$") && context.Request.Method == "DELETE")
//        {
//            int id;

//            if (Int32.TryParse(path.Split("/")[^1], out id))
//            {
//                var course = db.Courses.FirstOrDefault(c => c.Id == id);
//                if (course != null)
//                    db.Courses.Remove(course);
//            }
//        }
//    }
//);



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


