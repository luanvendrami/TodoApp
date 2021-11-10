using Dominio.Entidades;
using Dominio.Interfaces.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio.TodoAppRepositorio
{
    public interface ICadastroRepositorio : IBaseRepositorio<CadastroEntidades>
    {
        CadastroEntidades RetornaId(Guid id);
        List<CadastroEntidades> RetornaListaDataConclusao();
    }
}
