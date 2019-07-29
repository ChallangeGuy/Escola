using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Operações_Aluno
    {
        List<Aluno> listaAluno = new List<Aluno>();
        public Operações_Aluno()
        {
        }
        public void addAluno(int matricula)
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
            listaAluno.Add(a);
        }
        public void editAluno(int index)
        {
            Console.WriteLine("Aluno: " + listaAluno[index]._nome);
            Console.WriteLine("CPF: " + listaAluno[index]._cpf);
            Console.WriteLine("Data de Nascimento: " + listaAluno[index]._dataNascimento);
            Console.WriteLine("Endereço: " + listaAluno[index]._endereco);
            Console.WriteLine("Nota: " + listaAluno[index]._nota);
            Console.Write("\nO que voce quer alterar?\n[1] para Nome\n[2] para CPF\n[3] para Data de Nascimento\n[4] para Endereço\n[5] para Nota\n\n[9] para retornar\n\n[0] para Sair");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                    listaAluno[index]._nome = Console.ReadLine();
                        break;
                    case 2:
                    listaAluno[index]._cpf = Console.ReadLine();
                        break;
                    case 3:
                    listaAluno[index]._dataNascimento = Console.ReadLine();
                        break;
                    case 4:
                    listaAluno[index]._endereco = Console.ReadLine();
                        break;
                    case 5:
                    listaAluno[index]._nota = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                    Console.Clear();
                    break;
                    case 0:
                    Environment.Exit(0);
                        break;
                }
        }
        public void listarAlunos()
        {
            foreach (Aluno a in listaAluno)
            {
                Console.WriteLine(a._nome);
            }
        }
        public void excluiAluno(int index)
        {
            Console.WriteLine("Aluno: " + listaAluno[index]._nome);
            Console.WriteLine("CPF: " + listaAluno[index]._cpf);
            Console.WriteLine("Data de Nascimento: " + listaAluno[index]._dataNascimento);
            Console.WriteLine("Endereço: " + listaAluno[index]._endereco);
            Console.WriteLine("Nota: " + listaAluno[index]._nota);

            Console.WriteLine("Tem certeza que deseja excluir?\n[1] para Sim\n[0] para Não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                listaAluno.RemoveAt(index);
            }
            Console.WriteLine("Alunos registrados");
            foreach (Aluno a in listaAluno)
            {
                Console.WriteLine(a._nome);
            }
            if (opcao == 0)
            {
                excluiAluno(index);
            }
        }
    }
}
