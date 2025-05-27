using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;

namespace backend.Infrastructure.Data.Mappers
{
    public static class HistoricoReceitaMapper
    {
        public static HistoricoReceita ToDomain(HistoricoReceitaDocument doc, Receita receita)
        {
            return new HistoricoReceita
            {
                Id = doc.Id,
                DataReceita = doc.DataReceita,
                Receita = receita
            };
        }

        public static HistoricoReceitaDocument ToDocument(HistoricoReceita entity)
        {
            return new HistoricoReceitaDocument
            {
                Id = entity.Id,
                DataReceita = entity.DataReceita,
                ReceitaId = entity.Receita.Id
            };
        }
    }
}
