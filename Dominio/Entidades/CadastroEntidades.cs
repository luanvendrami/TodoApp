using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class CadastroEntidades
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataConclusão { get; set; }
        public bool TarefaConcluida { get; set; }

        public CadastroEntidades()
        {
            Id = Guid.NewGuid();
        }
    }
}
