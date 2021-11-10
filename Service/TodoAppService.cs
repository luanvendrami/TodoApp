
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.TodoAppRepositorio;
using Dominio.Interfaces.Repositorio.TodoAppService;
using Dominio.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Service
{
    public class TodoAppService : ITodoAppService
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;

        public TodoAppService(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }

        public void SalvarCadastro(CadastrarDto model)
        {
            if (model.DataConclusao >= DateTime.Now)
            {
                var entidadeCadastro = new CadastroEntidades
                {
                    Nome = model.Nome,
                    DataConclusao = model.DataConclusao,
                    TarefaConcluida = model.TarefaConcluida
                };
                _cadastroRepositorio.Adicionar(entidadeCadastro);
            }

            _cadastroRepositorio.SalvarAlteracao();
        }

        public List<CadastroEntidades> BuscarPorDataConclusao()
        {
            var consultaRepositorio = _cadastroRepositorio.RetornaListaDataConclusao();
            return consultaRepositorio;  
        }

        public void AlterarValorTarefa(Guid id, bool tarefa)
        {

            var consultaRepositorio = _cadastroRepositorio.RetornaId(id);
            if (consultaRepositorio.TarefaConcluida != tarefa)
            {
                consultaRepositorio.TarefaConcluida = tarefa;
                _cadastroRepositorio.Atualizar(consultaRepositorio);
            }

            _cadastroRepositorio.SalvarAlteracao();
        }
    }
}
