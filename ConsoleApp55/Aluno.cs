using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{

    public class Aluno
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public int Matricula { get; set; }
        public string Cursos { get; set; }
        public string Endereco { get; set; }
        public int Nota { get; set; }
        public List<Turma> Turmas { get; set; }
        public Aluno(string nome, string cpf, string dataNascimento, int matricula, string endereco, int nota, List<Turma> turmas)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Matricula = matricula;
            Endereco = endereco;
            Nota = nota;
            Turmas = turmas;

        }
        /*public Cursos alunoCursos()
        {
            Operações_Cursos oprCursos = new Operações_Cursos();
            string nomeCurso = oprCursos.nome;
            double notaCurso = oprCursos.nota;
            string codigoCurso = oprCursos.codigo;
            Cursos curso = new Cursos(nomeCurso, notaCurso, codigoCurso);
            return curso.exibeCurso();
        }*/
    }
}
