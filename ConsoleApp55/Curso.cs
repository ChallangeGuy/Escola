using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    public class Curso
    {
        public string Nome{ get; set; }
        public double NotaEnad { get; set; }
        public string Codigo { get; set; }
        public List<Turma> Turmas { get; set; }
        public Curso()
        {
            this.Turmas = new List<Turma>();
        }
        public Curso(string nome, double notaEnad, string codigo, List<Turma> turmas)
        {
            Nome = nome;
            NotaEnad = notaEnad;
            Codigo = codigo;
            Turmas = turmas;
        }
    }
}
