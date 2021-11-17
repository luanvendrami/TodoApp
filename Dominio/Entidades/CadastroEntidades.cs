using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class CadastroEntidades
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataConclusao { get; private set; }
        public bool TarefaConcluida { get; private set; }

        public CadastroEntidades()
        {
            
        }

        public CadastroEntidades(string nome, DateTime dataConclusao, bool tarefaConcluida)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataConclusao = dataConclusao;
            TarefaConcluida = tarefaConcluida;
            validacao();
        }

        public void validacao()
        {
            if (!string.IsNullOrEmpty(Nome)) { }
            if (!string.IsNullOrEmpty(DataConclusao.ToString())) { }
            if (!string.IsNullOrEmpty(TarefaConcluida.ToString())) { }
        }

        public bool ValidaTarefa(bool valor)
        {
            if (valor != TarefaConcluida)
            {
                TarefaConcluida = valor;
            }
            return TarefaConcluida;
        }
       


    }
}
