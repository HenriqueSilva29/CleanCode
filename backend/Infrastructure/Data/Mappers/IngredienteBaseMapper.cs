using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;

namespace backend.Infrastructure.Data.Mappers
{
    public static class IngredienteBaseMapper
    {
        public static IngredienteBase ToDomain(IngredienteBaseDocument doc)
        {
            return new IngredienteBase
            {
                Id = doc.Id,
                Nome = doc.Nome
            };
        }

        public static IngredienteBaseDocument ToDocument(IngredienteBase entity)
        {
            return new IngredienteBaseDocument
            {
                Id = entity.Id,
                Nome = entity.Nome
            };
        }
    }
}
