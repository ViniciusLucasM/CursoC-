using WebApi8.Dto.Vinculo;
using WebApi8.Models;

namespace WebApi8.Dto.Livros
{
    public class LivroCriacaoDTO
    {
        public string Titulo { get; set; }
        public AutorVinculoDTO Autor { get; set; }
    }
}
