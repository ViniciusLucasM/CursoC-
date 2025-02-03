using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebApi8.Dto.Livros;
using WebApi8.Models;
using WebApi8.Services.Livro;

namespace WebApi8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;
        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorId(int idLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivro);
            return Ok(livro);
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivros()
        {
            var livro = await _livroInterface.ListarLivros();
            return Ok(livro);
        }

        [HttpGet("ListarLivrosPorIdAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorIdAutor(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(idAutor);
            return Ok(livro);
        }

        [HttpDelete("RemoverLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> RemoverLivro(int idLivro)
        {
            var livro = await _livroInterface.RemoverLivro(idLivro);
            return Ok(livro);
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDTO livroCriacaoDTO) 
        {
            var livro = await _livroInterface.CriarLivro(livroCriacaoDTO);
            return Ok(livro);
        }

        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDTO livroEdicaoDTO)
        {
            var livro = await _livroInterface.EditarLivro(livroEdicaoDTO);
            return Ok(livro);
        }
    }
}
