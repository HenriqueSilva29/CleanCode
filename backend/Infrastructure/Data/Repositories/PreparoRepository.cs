using backend.Infrastructure.Data.Context;
using backend.Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace backend.Infrastructure.Data.Repositories
{
    public class PreparoRepository
    {
        private IMongoCollection<Receita> _receitaCollection;
    }
}
