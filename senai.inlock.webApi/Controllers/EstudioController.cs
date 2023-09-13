using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using senai.inlock.webApi_.Repositories;

namespace senai.inlock.webApi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController() 
        {
            _estudioRepository = new EstudioRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                List<EstudioDomain> ListaEstudio = _estudioRepository.ListarTodos();
                
                return Ok(ListaEstudio);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(EstudioDomain novoEstudio)
        {
            try
            {
                //Fazendo a chamada para o metodo cadastrar passando o objeto como parametro
                _estudioRepository.Cadastrar(novoEstudio);

                //retorna um status code 201 - created
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                //Retornar um status code 400(badrequest) e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }
    }
}
