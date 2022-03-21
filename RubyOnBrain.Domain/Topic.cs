using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RubyOnBrain.Domain
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        //public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        [JsonIgnore]
        public Course Course { get; set; }
        public List<Entry> Entries { get; set; } = new List<Entry>();
    }
}
