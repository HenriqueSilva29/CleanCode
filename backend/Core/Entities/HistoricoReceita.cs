namespace backend.Core.Entities
{
    /// <summary>
    /// Armazena o histórico de uso de uma receita pelo usuário.
    /// </summary>
    public class HistoricoReceita
    {
        public string Id { get; set; }
        public DateTime DataReceita { get; set; }
        public virtual Receita Receita{ get; set; }
    }
}
