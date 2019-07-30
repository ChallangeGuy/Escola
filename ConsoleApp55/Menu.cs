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
        Operações_Cursos oprCursos = new Operações_Cursos();
        public Menu()
        {
        }
        public void menuPrincipal()
        {
            Console.WriteLine("Digite a opção desejada: \n[1] para Alunos\n[2] para Professores\n[3] para Cursos\n[4] para Turma\n\n[0] para Sair");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    //função aluno
                    Console.WriteLine("---- ALUNO ----");
                    Console.Clear();
                    menuAluno();
                    break;
                case 2:
                    //função professor
                    Console.WriteLine("---- PROFESSOR ----");
                    Console.Clear();
                    menuProfessor();
                    break;
                case 3:
                    //função curso
                    Console.WriteLine("---- CURSO ----");
                    Console.Clear();
                    menuCursos();
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
                        contador++;
                        Console.WriteLine("\nMATRÍCULA: {0}\n", contador);
                        opr.addAluno(contador);
                        Console.WriteLine("\nDeseja adicionar mais um aluno?\n[1] para Sim\n\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
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
                    //adiciona professor
                    int contador = 0;
                    while (opcao != 0)
                    {
                        Console.Clear();
                        contador++;
                        Console.WriteLine("\nMATRÍCULA: {0}\n", contador);
                        oprProf.addProfessor(contador);
                        Console.WriteLine("\nDeseja adicionar mais um aluno?\n[1] para Sim\n\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Você adicionou {0} alunos", contador);
                    Console.ReadLine();
                    Console.Clear();
                    menuAluno();
                    break;
                case 2:
                    //edita aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do professor que deseja alterar: ");
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
                    Console.Write("Digite a Matrícula do professor que deseja excluir: ");
                    int matricula2 = int.Parse(Console.ReadLine());
                    oprProf.excluiProfessor(matricula2 - 1);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void menuCursos()
        {

            Console.Clear();
            Console.WriteLine("[1] para Adicionar\n[2] para Editar\n[3] para Listar\n[4] para Excluir\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    //adiciona cursos
                    int contador = 0;
                    while (opcao != 0)
                    {
                        Console.Clear();
                        oprCursos.addCursos();
                        Console.WriteLine("\nDeseja adicionar mais um curso?\n[1] para Sim\n\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
                        contador++;
                    }
                    Console.WriteLine("Você adicionou {0} alunos", contador);
                    Console.ReadLine();
                    Console.Clear();
                    menuCursos();
                    break;
                case 2:
                    //edita aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja alterar: ");
                    int matricula = int.Parse(Console.ReadLine());
                    oprCursos.editCursos(matricula - 1);

                    break;
                case 3:
                    //lista aluno
                    oprCursos.listarCursos();
                    break;
                case 4:
                    //exclui aluno
                    Console.Clear();
                    Console.Write("Digite a Matrícula do aluno que deseja excluir: ");
                    int matricula2 = int.Parse(Console.ReadLine());
                    oprCursos.excluiCursos(matricula2 - 1);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
