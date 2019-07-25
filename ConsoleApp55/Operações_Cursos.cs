using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Operações_Cursos
    {
        public List<Cursos> listaCursos = new List<Cursos>();
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
            Cursos c = new Cursos(nome, nota, codigo);
            listaCursos.Add(c);
        }
    }
}
