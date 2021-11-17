
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
                var entidadeCadastro = new CadastroEntidades(model.Nome, model.DataConclusao, model.TarefaConcluida);
                _cadastroRepositorio.Adicionar(entidadeCadastro);
            }

            _cadastroRepositorio.SalvarAlteracao();
        }

        public List<CadastroEntidades> BuscarPorDataConclusao()
        {
            var consultaRepositorio = _cadastroRepositorio.RetornaListaDataConclusao();
            return consultaRepositorio;  
        }

        public string AlterarValorTarefa(Guid id, bool tarefa)
        {
            var consultaRepositorio = _cadastroRepositorio.RetornaId(id);

            if (consultaRepositorio.TarefaConcluida == tarefa)
                return $"Tarefa com id: {id} está com o mesmo valor atual, verifique.";
            else
                consultaRepositorio.ValidaTarefa(tarefa);

            _cadastroRepositorio.Atualizar(consultaRepositorio);
            _cadastroRepositorio.SalvarAlteracao();
            return $"Tarefa com id: {id} foi alterada com sucesso.";
        }
    }
}
