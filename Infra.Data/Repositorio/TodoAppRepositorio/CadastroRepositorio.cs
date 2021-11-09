using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.TodoAppRepositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositorio.TodoAppRepositorio
{
    public class CadastroRepositorio : BaseRepositorio<CadastroEntidades>, ICadastroRepositorio
    {
        public CadastroRepositorio(AppContexto contexto) : base(contexto) { }


    }
}
