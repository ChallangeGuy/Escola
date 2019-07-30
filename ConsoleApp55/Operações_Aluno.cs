using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    static class Operações_Aluno
    {
        public static readonly List<Aluno> _listaAluno;
        static Operações_Aluno()
        {
            _listaAluno = new List<Aluno>();
        }

        public static void addAluno(int matricula)
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
            Aluno a = new Aluno(nome, cpf, dataNascimento, matricula, endereco, nota);
            _listaAluno.Add(a);
        }
        public static void editAluno(int index)
        {
            Console.WriteLine("Aluno: " + _listaAluno[index].Nome);
            Console.WriteLine("CPF: " + _listaAluno[index].Cpf);
            Console.WriteLine("Data de Nascimento: " + _listaAluno[index].DataNascimento);
            Console.WriteLine("Endereço: " + _listaAluno[index].Endereco);
            Console.WriteLine("Nota: " + _listaAluno[index].Nota);
            Console.Write("\nO que voce quer alterar?\n[1] para Nome\n[2] para CPF\n[3] para Data de Nascimento\n[4] para Endereço\n[5] para Nota\n\n[9] para retornar\n\n[0] para Sair");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("O antigo nome é: {0}\n", _listaAluno[index].Nome);
                    Console.Write("Digite o novo nome: ");
                    _listaAluno[index].Nome = Console.ReadLine();
                        break;
                    case 2:
                    Console.Clear();
                    Console.WriteLine("O antigo CPF é: {0}\n", _listaAluno[index].Cpf);
                    Console.Write("Digite o novo CPF: ");
                    _listaAluno[index].Cpf = Console.ReadLine();
                        break;
                    case 3:
                    Console.Clear();
                    Console.WriteLine("A antiga data de nascimento é: {0}\n", _listaAluno[index].DataNascimento);
                    Console.Write("Digite a nova data de nascimento: ");
                    _listaAluno[index].DataNascimento = Console.ReadLine();
                        break;
                    case 4:
                    Console.Clear();
                    Console.WriteLine("O antigo endereço é: {0}\n", _listaAluno[index].Endereco);
                    Console.Write("Digite o novo endereço: ");
                    _listaAluno[index].Endereco = Console.ReadLine();
                        break;
                    case 5:
                    Console.Clear();
                    Console.WriteLine("A antiga nota é: {0}\n", _listaAluno[index].Nota);
                    Console.Write("Digite a nova nota: ");
                    _listaAluno[index].Nota = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                    Console.Clear();
                    
                    break;
                    case 0:
                    Environment.Exit(0);
                        break;
                }
        }
        public static List<Aluno> ListarAlunos()
        {
            //foreach (Aluno a in _listaAluno)
            //{
            //    Console.WriteLine(a.Nome);
            //}
            return _listaAluno;
        }
        public static void excluiAluno(int index)
        {
            Console.WriteLine("Aluno: " + _listaAluno[index].Nome);
            Console.WriteLine("CPF: " + _listaAluno[index].Cpf);
            Console.WriteLine("Data de Nascimento: " + _listaAluno[index].DataNascimento);
            Console.WriteLine("Endereço: " + _listaAluno[index].Endereco);
            Console.WriteLine("Nota: " + _listaAluno[index].Nota);

            Console.WriteLine("Tem certeza que deseja excluir?\n[1] para Sim\n[0] para Não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                _listaAluno.RemoveAt(index);
            }
            Console.WriteLine("Alunos registrados");
            foreach (Aluno a in _listaAluno)
            {
                Console.WriteLine(a.Nome);
            }
            if (opcao == 0)
            {
                excluiAluno(index);
            }
        }
    }
}
