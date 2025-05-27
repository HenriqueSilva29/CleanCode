using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;

namespace backend.Infrastructure.Data.Mappers
{
    /// <summary>
    /// Realiza o mapeamento entre Receita (domínio) e ReceitaDocument (MongoDB).
    /// </summary>
    public static class ReceitaMapper
    {
        public static Receita ToDomain(ReceitaDocument doc)
        {
            return new Receita
            {
                Id = doc.Id,
                Titulo = doc.Titulo,
                Dificuldade = doc.Dificuldade,
                PorcaoPessoas = doc.PorcaoPessoas,
                Ingredientes = doc.Ingredientes,
                Preparo = doc.Preparo,
                Observacao = doc.Observacao
            };
        }

        public static ReceitaDocument ToDocument(Receita receita)
        {
            return new ReceitaDocument
            {
                Id = receita.Id,
                Titulo = receita.Titulo,
                Dificuldade = receita.Dificuldade,
                PorcaoPessoas = receita.PorcaoPessoas,
                Ingredientes = receita.Ingredientes,
                Preparo = receita.Preparo,
                Observacao = receita.Observacao
            };
        }
    }
}
