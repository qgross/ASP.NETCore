using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        public List<Letter> Letters { get; set; }

        public string NameStatus { get; set; }
    }
}
