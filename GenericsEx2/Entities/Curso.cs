using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx2.Entities
{
    public  class Curso
    {
        public string Nome { get; set; }

        public Curso() 
        {

        }
        public Curso(string nome)
        {
            Nome = nome;
        }
    }
}
