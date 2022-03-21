using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyOnBrain.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        [ForeignKey("ProgLangId")]
        public ProgLang ProgLang { get; set; }
        //public int ProgLangId { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
