using backend.Core.Enums;

namespace backend.Core.Entities
{
    /// <summary>
    /// Representa uma receita culinária na camada de domínio.
    /// </summary>
    public class Receita
    {
        public string Id { get; set; }
        public string? Titulo { get; set; }
        public DificuldadeReceita Dificuldade { get; set; }
        public int PorcaoPessoas { get; set; }

        public Dictionary<string, Dictionary<string, string>> Ingredientes { get; set; }
        public Dictionary<string, Dictionary<string, string>> Preparo { get; set; }

        public string? Observacao { get; set; }
    }
}
