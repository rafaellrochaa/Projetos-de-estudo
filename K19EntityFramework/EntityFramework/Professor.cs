using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class Professor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
