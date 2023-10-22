using System;
using System.Collections.Generic;
using GenericsEx2.Entities;


namespace GenericsEx2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<Aluno> alunos = new HashSet<Aluno>();
            alunos.UnionWith(Matricula("A"));
            alunos.UnionWith(Matricula("B"));
            alunos.UnionWith(Matricula("C"));
            Console.WriteLine($"Total Student:{alunos.Count}");

        }
        static HashSet<Aluno> Matricula(string c)
        {
            HashSet<Aluno> alunos = new HashSet<Aluno>();

            Console.Write($"How many students for course {c}?");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                List<Curso> list = new List<Curso>();
                Curso curso = new Curso(c);
                int id = int.Parse(Console.ReadLine());
                list.Add(curso);
                Aluno aluno = new Aluno(id, list);
                alunos.Add(aluno);
            }
            return alunos;
        }
    }
}