using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;

namespace backend.Infrastructure.Data.Mappers
{
    public static class IngredienteReceitaMapper
    {
        public static IngredienteReceita ToDomain(IngredienteReceitaDocument doc)
        {
            return new IngredienteReceita
            {
                Id = doc.Id,
                Ingredientes = doc.Ingredientes
            };
        }

        public static IngredienteReceitaDocument ToDocument(IngredienteReceita entity)
        {
            return new IngredienteReceitaDocument
            {
                Id = entity.Id,
                Ingredientes = entity.Ingredientes
            };
        }
    }
}
