namespace backend.Core.Entities
{
    /// <summary>
    /// Representa um ingrediente genérico que pode ser utilizado em várias receitas.
    /// </summary>
    public class IngredienteBase
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
    }
}
