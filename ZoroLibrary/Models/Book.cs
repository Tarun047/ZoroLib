using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoroLibrary.Models
{
    public class Book
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
