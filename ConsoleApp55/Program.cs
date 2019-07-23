using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----ESCOLA----");
            Console.WriteLine("Digite a opção desejada: \n[1] para Alunos\n[2] para Professores\n[3] para Cursos\n[4] para Turma\n\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            Menu menu = new Menu();
            menu.menuPrincipal(opcao);

            Console.ReadLine();
        }
    }
}
