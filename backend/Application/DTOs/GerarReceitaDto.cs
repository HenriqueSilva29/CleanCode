using backend.Core.Enums;

namespace backend.Application.DTOs
{
    /// <summary>
    /// Estrutura de dados para receber a requisição de geração de receita via ingredientes.
    /// </summary>
    public class GerarReceitaDto
    {
        public DificuldadeReceita Dificuldade { get; set; }

        public string PorcaoPessoas { get; set; }

        public List<string> Ingredientes { get; set; }
    }
}
