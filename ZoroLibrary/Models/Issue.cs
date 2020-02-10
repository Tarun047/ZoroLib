using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoroLibrary.Models
{
    public class Issue
    {
        public long Id { get; set; }

        public long BookId { get; set; }

        public long UserId { get; set; }
    }
}
