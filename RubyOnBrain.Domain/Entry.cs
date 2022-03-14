using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyOnBrain.Domain
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImgName { get; set; }
        public string VideoName { get; set; }
        public EntryType EntryType { get; set; }
        public Topic Topic { get; set; }
        public int EntryTypeId { get; set; }

    }
}
