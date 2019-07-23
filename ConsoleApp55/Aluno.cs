using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Aluno
    {
        public string _nome { get; set; }
        public string _cpf { get; set; }
        public string _dataNascimento { get; set; }
        //public int _matricula { get; set; }
        public string _cursos { get; set; }
        public string _endereco { get; set; }
        public int _nota { get; set; }
        public Aluno(string nome, string cpf, string dataNascimento, string endereco, int nota)
        {
            _nome = nome;
            _cpf = cpf;
            _dataNascimento = dataNascimento;
            _endereco = endereco;
            _nota = nota;
        }
    }
}
