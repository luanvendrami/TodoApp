﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class CadastrarDto
    {
        public string Nome { get; set; }
        public DateTime DataConclusao { get; set; }
        public bool TarefaConcluida { get; set; }
    }
}
