using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Professor
    {
        public string _nome { get; set; }
        public string _cpf { get; set; }
        public string _dataNascimento { get; set; }
        public int _matricula { get; set; }
        public string _turmas { get; set; }
        public double _salario { get; set; }
        public string _dataAdmissao { get; set; }
        public Professor(string nome, string cpf, string dataNascimento, int matricula, double salario, string dataAdmissao)
        {
            _nome = nome;
            _cpf = cpf;
            _dataNascimento = dataNascimento;
            _salario = salario;
            _dataAdmissao = dataAdmissao;
            _matricula = matricula;
        }
    }
}
