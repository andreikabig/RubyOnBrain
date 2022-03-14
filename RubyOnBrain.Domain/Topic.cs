using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyOnBrain.Domain
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Entry> Entries { get; set; } = new List<Entry>();
    }
}
