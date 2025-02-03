using WebApi8.Dto.Livros;
using WebApi8.Models;

namespace WebApi8.Services.Livro
{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDTO livroCriacaoDTO);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDTO livroEdicaoDTO);
        Task<ResponseModel<List<LivroModel>>> RemoverLivro(int idLivro);
    }
}
