using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class Letter
    {

        public int LetterId { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string FormSec { get; set; }
        public User UserId { get; set; }
        public Kontragent Kontragent { get; set; }
        public int KontragentId { get; set; }
        public Status Status { get; set; }
        public Tema Tema { get; set; }
        


    }
}
