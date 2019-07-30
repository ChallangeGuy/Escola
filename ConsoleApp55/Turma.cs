using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    public class Turma
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public List<Aluno> Alunos { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Curso> Cursos { get; set; }

        public Turma()
        {
            this.Alunos = new List<Aluno>();
            this.Professores = new List<Professor>();
            this.Cursos = new List<Curso>();
        }
        public Turma(string nome, string codigo, List<Aluno> alunos, List<Professor> professores, List<Curso> cursos)
        {
            Nome = nome;
            Codigo = codigo;
            Alunos = alunos;
            Professores = professores;
            Cursos = cursos;
        }
    }
}
