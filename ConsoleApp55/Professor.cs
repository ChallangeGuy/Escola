using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public int Matricula { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        public List<Turma> Turmas { get; set; }
        public Professor()
        {
            this.Turmas = new List<Turma>();
        }
        public Professor(string nome, string cpf, string dataNascimento, int matricula, double salario, string dataAdmissao, List<Turma> turmas)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            Matricula = matricula;
            Turmas = turmas;
        }
    }
}
