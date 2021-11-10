using Dominio.Entidades;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio.TodoAppService
{
    public interface ITodoAppService
    {
        void SalvarCadastro(CadastrarDto model);
        List<CadastroEntidades> BuscarPorDataConclusao();
        void AlterarValorTarefa(Guid id, bool tarefa);
    }
}
