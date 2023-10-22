using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx2.Entities
{
    public class Aluno
    {
        public int CodigoUnico { get; set; }
        public List<Curso> _Cursos { get; set; }

        public Aluno() { }

        public Aluno(int codigoUnico, List<Curso> cursos)
        {
            CodigoUnico = codigoUnico;
            _Cursos = cursos;
        }

        public override int GetHashCode()
        {
            return CodigoUnico.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Aluno))
            {
                return false;
            }
            Aluno other = obj as Aluno;

            return CodigoUnico.Equals(other.CodigoUnico);
        }
    }
}
