using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Operações_Cursos
    {
        public List<Curso> listaCursos = new List<Curso>();
        public Operações_Cursos()
        {
        }
        public string nome;
        public double nota;
        public string codigo;
        public void addCursos()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Nota Enad: ");
            nota = double.Parse(Console.ReadLine());
            Console.Write("Código ");
            codigo = Console.ReadLine();
            Curso c = new Curso(nome, nota, codigo);
            listaCursos.Add(c);
        }
        public void editCursos(int index)
        {
            Console.WriteLine("Aluno: " + listaCursos[index].Nome);
            Console.WriteLine("CPF: " + listaCursos[index].NotaEnad);
            Console.WriteLine("Data de Nascimento: " + listaCursos[index].Codigo);
            Console.Write("\nO que voce quer alterar?\n[1] para Nome\n[2] para Nota\n[3] para Codigo\n\n[9] para retornar\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    listaCursos[index].Nome = Console.ReadLine();
                    break;
                case 2:
                    listaCursos[index].NotaEnad = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    listaCursos[index].Codigo = Console.ReadLine();
                    break;
                case 9:
                    Console.Clear();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void listarCursos()
        {
            foreach (Curso c in listaCursos)
            {
                Console.WriteLine("Nome do Curso: " + c.Nome);
            }
        }
        public void excluiCursos(int index)
        {
            Console.WriteLine("Aluno: " + listaCursos[index].Nome);
            Console.WriteLine("CPF: " + listaCursos[index].NotaEnad);
            Console.WriteLine("Data de Nascimento: " + listaCursos[index].Codigo);
            Console.WriteLine("Tem certeza que deseja excluir?\n[1] para Sim\n[0] para Não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                listaCursos.RemoveAt(index);
            }
            Console.WriteLine("Alunos registrados");
            foreach (Curso c in listaCursos)
            {
                Console.WriteLine(c.Nome);
            }
            if (opcao == 0)
            {
                excluiCursos(index);
            }
        }
    }
}
