using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Menu
    {
        Operações_Aluno opr = new Operações_Aluno();
        Operações_Professor oprProf = new Operações_Professor();
        public void menuPrincipal(int i)
        {
            switch (i)
            {
                case 1:
                    //função aluno
                    Console.Clear();
                    menuAluno();
                    break;
                case 2:
                    //função professor
                    menuProfessor();
                    break;
                case 3:
                    //função curso
                    break;
                case 4:
                    //função turma
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void menuAluno()
        {
            
            Console.Clear();
            Console.WriteLine("[1] para Adicionar\n[2] para Editar\n[3] para Listar\n[4] para Excluir\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    //adiciona aluno
                    int contador = 0;
                    while (opcao != 0)
                    {
                        Console.Clear();
                        opr.addAluno();
                        Console.WriteLine("\nDeseja adicionar mais um aluno?\n[1] para Sim\n\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
                        contador++;
                    }
                    Console.WriteLine("Você adicionou {0} alunos", contador);
                    Console.ReadLine();
                    Console.Clear();
                    menuAluno();
                    break;
                case 2:
                    //edita aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja alterar: ");
                    int matricula = int.Parse(Console.ReadLine());
                    opr.editAluno(matricula - 1);

                    break;
                case 3:
                    //lista aluno
                    opr.listarAlunos();
                    break;
                case 4:
                    //exclui aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja excluir: ");
                    int matricula2 = int.Parse(Console.ReadLine());
                    opr.excluiAluno(matricula2 - 1);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void menuProfessor()
        {

            Console.Clear();
            Console.WriteLine("[1] para Adicionar\n[2] para Editar\n[3] para Listar\n[4] para Excluir\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    //adiciona aluno
                    int contador = 0;
                    while (opcao != 0)
                    {
                        Console.Clear();
                        oprProf.addProfessor();
                        Console.WriteLine("\nDeseja adicionar mais um aluno?\n[1] para Sim\n\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
                        contador++;
                    }
                    Console.WriteLine("Você adicionou {0} alunos", contador);
                    Console.ReadLine();
                    Console.Clear();
                    menuAluno();
                    break;
                case 2:
                    //edita aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja alterar: ");
                    int matricula = int.Parse(Console.ReadLine());
                    oprProf.editProfessor(matricula - 1);

                    break;
                case 3:
                    //lista aluno
                    oprProf.listarProfessor();
                    break;
                case 4:
                    //exclui aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja excluir: ");
                    int matricula2 = int.Parse(Console.ReadLine());
                    oprProf.excluiProfessor(matricula2 - 1);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
