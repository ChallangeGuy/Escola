using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Adicionar
    {
        private List<Aluno> listaAluno = new List<Aluno>();
        public void addAluno()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Data de Nascimeto: ");
            string dataNascimento = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Nota: ");
            int nota = int.Parse(Console.ReadLine());
            Aluno a = new Aluno(nome, cpf, dataNascimento, endereco, nota);
            listaAluno.Add(a);
        }
    }
}
