using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Project
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        [JsonPropertyName("lang")]
        public string Language { get; set; }
        [JsonPropertyName("langColor")]
        public string LanguageColor { get; set; }
        [JsonPropertyName("link")]
        public string ProjectUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Image { get; set; } = "GitHub-Mark.png";
        public Technology[] Technologies { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }

    public class Technology
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string FontColor { get; set; } = "#fff";
    }
}
