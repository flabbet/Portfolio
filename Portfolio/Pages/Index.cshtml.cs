using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProjectService ProjectService;
        public IEnumerable<Project> Projects { get; private set; }
        public int Age
        {
            get
            {
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(new DateTime(2003, 3, 24).ToString("yyyyMMdd"));
                int age = (now - dob) / 10000;
                return age;
            }
        }
        public IndexModel(ILogger<IndexModel> logger, JsonFileProjectService projectService)
        {
            _logger = logger;
            ProjectService = projectService;
        }

        public void OnGet()
        {
            Projects = ProjectService.GetProjects();
        }
    }
}
