using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Operações_Professor
    {
        public List<Professor> listaProfessor = new List<Professor>();
        public void addProfessor(int matricula)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Data de Nascimeto: ");
            string dataNascimento = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Data de Admissão ");
            string dataAdmissao = Console.ReadLine();
            Professor p = new Professor(nome, cpf, dataNascimento, matricula, salario, dataAdmissao);
            listaProfessor.Add(p);
        }
        public void editProfessor(int index)
        {
            Console.WriteLine("Aluno: " + listaProfessor[index]._nome);
            Console.WriteLine("CPF: " + listaProfessor[index]._cpf);
            Console.WriteLine("Data de Nascimento: " + listaProfessor[index]._dataNascimento);
            Console.WriteLine("Salario: " + listaProfessor[index]._salario);
            Console.WriteLine("Data de Admissão: " + listaProfessor[index]._dataAdmissao);
            Console.Write("\nO que voce quer alterar?\n[1] para Nome\n[2] para CPF\n[3] para Data de Nascimento\n[4] para Salario\n[5] para Data de Admissão\n\n[9] para retornar\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    listaProfessor[index]._nome = Console.ReadLine();
                    break;
                case 2:
                    listaProfessor[index]._cpf = Console.ReadLine();
                    break;
                case 3:
                    listaProfessor[index]._dataNascimento = Console.ReadLine();
                    break;
                case 4:
                    listaProfessor[index]._salario = double.Parse(Console.ReadLine());
                    break;
                case 5:
                    listaProfessor[index]._dataAdmissao = Console.ReadLine();
                    break;
                case 9:

                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void listarProfessor()
        {
            foreach (Professor p in listaProfessor)
            {
                Console.WriteLine(p._nome);
            }
        }
        public void excluiProfessor(int index)
        {
            Console.WriteLine("Aluno: " + listaProfessor[index]._nome);
            Console.WriteLine("CPF: " + listaProfessor[index]._cpf);
            Console.WriteLine("Data de Nascimento: " + listaProfessor[index]._dataNascimento);
            Console.WriteLine("Salario: " + listaProfessor[index]._salario);
            Console.WriteLine("Data de Admissão: " + listaProfessor[index]._dataAdmissao);

            Console.WriteLine("Tem certeza que deseja excluir?\n[1] para Sim\n[0] para Não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                listaProfessor.RemoveAt(index);
            }
            Console.WriteLine("Alunos registrados");
            foreach (Professor p in listaProfessor)
            {
                Console.WriteLine(p._nome);
            }
            if (opcao == 0)
            {
                excluiProfessor(index);
            }
        }
    }

}