namespace backend.Core.Entities
{
    /// <summary>
    /// Representa o histórico de uma receita gerada pelo usuário, com data de criação.
    /// </summary>
    public class HistoricoReceita
    {
        public string Id { get; set; } = string.Empty;
        public DateTime DataReceita { get; set; }

        /// <summary>
        /// Receita associada ao histórico.
        /// </summary>
        public Receita Receita { get; set; }
    }
}
