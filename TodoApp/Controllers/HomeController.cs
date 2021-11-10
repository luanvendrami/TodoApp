using Dominio.Interfaces.Repositorio.TodoAppService;
using Dominio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly ITodoAppService _todoAppService;

        public HomeController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        //Metodo para buscar os cadastros pela data de conclusão, do mais próximo a esgotar(Data atual) para o com a data mais distante.
        [HttpGet("BuscaDataConclusao")]
        public ActionResult<List<CadastrarDto>> BuscaDataConclusao()
        {
            try
            {
                var retorno = _todoAppService.BuscarPorDataConclusao();
                return Ok(retorno);
            }
            catch
            {
                return NotFound($"Busca por data não foi possível.");
            }
        }

        //Metodo para salvar no banco o cadastro, o ID é gerado automaticamente na entidade do mesmo, como GUID.
        [HttpPost("SalvarCadastro")]
        public ActionResult Salvar([FromForm]CadastrarDto model)
        {
            try
            {
                _todoAppService.SalvarCadastro(model);
                return Ok($"Cadastro: {model.Nome} foi salvo com sucesso.");
            }
            catch
            {
                return NotFound($"Cadastro: {model.Nome} não foi salvo.");
            }          
        }

        //Metodo que busca o cadastro pelo ID e altera a entidade de Tarefa.
        [HttpPut("AtualizarTarefa")]
        public ActionResult AlterarTarefa(Guid id, bool tarefa)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                try
                {

                    _todoAppService.AlterarValorTarefa(id, tarefa);
                    return Ok($"Tarefa com id: {id} foi alterada com sucesso.");
                }

                catch (Exception)
                {
                    return NotFound($"Tarefa com id: {id} não foi alterada.");
                }                
            }
            return NotFound($"Tarefa com id: {id} não foi alterada.");
        }

    }
}
