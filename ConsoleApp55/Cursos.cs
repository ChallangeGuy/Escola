﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Cursos
    {
        public string _nome{ get; set; }
        public string _turmas { get; set; }
        public double _notaEnad { get; set; }
        public string _codigo { get; set; }
        public Cursos(string nome, double notaEnad, string codigo)
        {
            _nome = nome;
            _notaEnad = notaEnad;
            _codigo = codigo;
        }
    }
}
