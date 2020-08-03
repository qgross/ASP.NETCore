using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class Tema
    {
        public int TemaId { get; set; }

        public List<Letter> Letters { get; set; }

        public string NameTema { get; set; }
    }
}
