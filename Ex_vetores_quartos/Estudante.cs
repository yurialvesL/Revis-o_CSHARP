using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_vetores_quartos
{
    internal class Estudante
    {
        public string _nome { get; set; }
        public string _email { get; set; }
        
        public int _quarto { get; set; }
        public Estudante(string nome, string email, int quarto)
        {
            _nome = nome;
            _email = email;
            _quarto = quarto;
        }
    }
}
