using Newtonsoft.Json;
using backend.Utils;

namespace backend.Core.Entities
{
    /// <summary>
    /// Representa o conjunto de ingredientes utilizados em uma receita, organizados por etapas ou categorias.
    /// </summary>
    public class IngredienteReceita
    {
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Ingredientes agrupados por etapa, em formato chave:valor.
        /// </summary>
        [JsonConverter(typeof(Conversor))]
        public Dictionary<string, Dictionary<string, string>> Ingredientes { get; set; } = new();
    }
}
