using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class Kontragent
    {
        public int KontragentId { get; set; }

        public List<Letter> Letters { get; set; }

        public string NameContragent { get; set; }
    }
}
