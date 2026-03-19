using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Required for List<>

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        // Changed to TaskItem[] or List<TaskItem> to be more explicit
        public ActionResult<IEnumerable<TaskItem>> GetTasks()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Finish React Setup", IsCompleted = true },
                new TaskItem { Id = 2, Title = "Connect to .NET API", IsCompleted = false },
                new TaskItem { Id = 3, Title = "Deploy to Codespaces", IsCompleted = false }
            };

            return Ok(tasks);
        }
    }

    // Move the class definition outside the Controller class but inside the namespace
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
