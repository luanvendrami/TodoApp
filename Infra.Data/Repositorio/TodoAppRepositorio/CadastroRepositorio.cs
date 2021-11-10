using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.TodoAppRepositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repositorio.TodoAppRepositorio
{
    public class CadastroRepositorio : BaseRepositorio<CadastroEntidades>, ICadastroRepositorio
    {
        public CadastroRepositorio(AppContexto contexto) : base(contexto) { }

        //Busca no banco os cadastros pelo ID.
        public CadastroEntidades RetornaId(Guid id)
            => _context.Cadastro.AsTracking().FirstOrDefault(x => x.Id == id);

        //Busca a lista de cadastros pela DataConclusao, a regra aplicada foi do dia mais próximo a esgotar (Data atual) viria como primeiro e as que estivessem com a TarefaConcluida como false.
        public List<CadastroEntidades> RetornaListaDataConclusao()
            => _context.Cadastro.AsTracking().Where(x => x.DataConclusao >= DateTime.Now && x.TarefaConcluida == false).OrderBy(x => x.DataConclusao).ToList();
    }
}
