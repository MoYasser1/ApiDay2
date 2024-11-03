using ApiDay1;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly List<Course> _courses;

    public CoursesController()
    {
        _courses = new List<Course>
        {
           new Course { Id = 1, Name = " C# ", Description = "تعلم أساسيات لغة C# لبناء تطبيقات ويب وواجهات مستخدم" },
            new Course { Id = 2,  Name = "React JS ", Description = "استخدام React لبناء واجهات مستخدم  وتطبيقات  " },
            new Course { Id = 3,  Name = "SQL Server", Description = "تعلم إدارة قواعد بيانات SQL Server" },
            new Course { Id = 4,  Name = "Python ", Description = "استخدام Python لتحليل البيانات وتعلم نماذج التعلم الآلي" },
            new Course { Id = 5,  Name = "ASP.NET Core", Description = "بناء تطبيقات ويب قوية ومؤمنة باستخدام ASP.NET Core" }        };
    }

    [HttpGet]
    public IActionResult GetAllCourses()
    {
        return Ok(_courses);
    }
}