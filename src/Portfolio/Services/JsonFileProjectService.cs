using Microsoft.AspNetCore.Hosting;
using Portfolio.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Portfolio.Services
{
    public class JsonFileProjectService
    {
        public IWebHostEnvironment WebHostEnviroment{ get; }
        private string JsonFileName => Path.Combine(WebHostEnviroment.WebRootPath, "data", "projects.json");

        public JsonFileProjectService(IWebHostEnvironment webHostEnviroment)
        {
            WebHostEnviroment = webHostEnviroment;
        }

        public IEnumerable<Project> GetProjects()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Project[]>(jsonFileReader.ReadToEnd(), 
                    new JsonSerializerOptions 
                    { 
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
