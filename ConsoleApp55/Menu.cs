using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Menu
    {
        public void menuPrincipal(int i)
        {
            switch (i)
            {
                case 1:
                    Console.Clear();
                    menuAluno();
                    //função aluno
                    break;
                case 2:
                    //função professor
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
            Console.WriteLine("[1] para Adicionar\n[2] para Editar\n[3] para Listar\n[4] para Excluir\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    //adiciona aluno
                    Adicionar adc = new Adicionar();
                    int contador = 0;
                    while (opcao != 0)
                    {
                        Console.Clear();
                        adc.addAluno();
                        Console.Clear();
                        Console.WriteLine("Deseja adicionar mais um aluno?\n[1] para Sim\n[0] para Não");
                        opcao = int.Parse(Console.ReadLine());
                        contador++;
                    }
                    Console.WriteLine("Você adicionou {0} alunos", contador);
                    break;
                case 2:
                    //edita aluno
                    break;
                case 3:
                    //lista aluno
                    break;
                case 4:
                    //exclui aluno
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
