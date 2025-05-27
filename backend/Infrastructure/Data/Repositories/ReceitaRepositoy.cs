using backend.Core.Entities;
using backend.Core.Interfaces;
using backend.Infrastructure.Data.Context;
using backend.Infrastructure.Data.MongoModels;
using backend.Infrastructure.Data.Mappers;
using backend.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using backend.Data.Dto;

namespace backend.Infrastructure.Data.Repositories
{
    public class ReceitaRepository : IReceita
    {
        private readonly IMongoCollection<ReceitaDocument> _receitaCollection;

        public ReceitaRepository(IOptions<MongoDbConfig> mongoConfig)
        {
            var mongoClient = new MongoClient(mongoConfig.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoConfig.Value.DatabaseName);
            _receitaCollection = mongoDatabase.GetCollection<ReceitaDocument>("Receitas");
        }

        public async Task<Response<string>> CreateAsync(Receita receita)
        {
            try
            {
                var receitaDoc = ReceitaMapper.ToDocument(receita);
                await _receitaCollection.InsertOneAsync(receitaDoc);
                return new Response<string>
                {
                    Success = true,
                    Text = "Receita criada com sucesso",
                    Data = receitaDoc.Id
                };
            }
            catch (Exception ex)
            {
                Logger.CriarLog("Falha ao inserir receita: " + ex.Message);
                return new Response<string>
                {
                    Success = false,
                    ErrorMessage = "Falha ao inserir receita: " + ex.Message
                };
            }
        }

        public async Task<Response<List<Receita>>> GetAsync()
        {
            try
            {
                var documentos = await _receitaCollection.Find(_ => true).ToListAsync();
                var receitas = documentos.Select(ReceitaMapper.ToDomain).ToList();

                return new Response<List<Receita>>
                {
                    Success = true,
                    Data = receitas
                };
            }
            catch (Exception ex)
            {
                return new Response<List<Receita>>
                {
                    Success = false,
                    ErrorMessage = "Erro ao buscar receitas: " + ex.Message
                };
            }
        }

        public async Task<Response<Receita>> GetAsync(string id)
        {
            try
            {
                var doc = await _receitaCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
                if (doc == null)
                {
                    return new Response<Receita>
                    {
                        Success = false,
                        ErrorMessage = "Receita não encontrada"
                    };
                }

                return new Response<Receita>
                {
                    Success = true,
                    Data = ReceitaMapper.ToDomain(doc)
                };
            }
            catch (Exception ex)
            {
                return new Response<Receita>
                {
                    Success = false,
                    ErrorMessage = "Erro interno: " + ex.Message
                };
            }
        }

        public async Task<Response<string>> UpdateAsync(string id, Receita receita)
        {
            try
            {
                var doc = ReceitaMapper.ToDocument(receita);
                var result = await _receitaCollection.ReplaceOneAsync(x => x.Id == id, doc);

                if (result.ModifiedCount == 0)
                {
                    return new Response<string>
                    {
                        Success = false,
                        ErrorMessage = "Receita não encontrada ou não modificada"
                    };
                }

                return new Response<string>
                {
                    Success = true,
                    Text = "Receita atualizada com sucesso",
                    Data = id
                };
            }
            catch (Exception ex)
            {
                return new Response<string>
                {
                    Success = false,
                    ErrorMessage = "Erro ao atualizar: " + ex.Message
                };
            }
        }

        public async Task<Response<string>> RemoveAsync(string id)
        {
            try
            {
                var result = await _receitaCollection.DeleteOneAsync(x => x.Id == id);

                return new Response<string>
                {
                    Success = result.DeletedCount > 0,
                    ErrorMessage = result.DeletedCount == 0 ? "Receita não encontrada" : null
                };
            }
            catch (Exception ex)
            {
                return new Response<string>
                {
                    Success = false,
                    ErrorMessage = "Erro ao excluir: " + ex.Message
                };
            }
        }

        Task<Response<List<Receita>>> IReceita.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<Response<Receita>> IReceita.GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<Response<string>> IReceita.CreateAsync(Receita receita)
        {
            throw new NotImplementedException();
        }

        Task<Response<string>> IReceita.UpdateAsync(string id, Receita receita)
        {
            throw new NotImplementedException();
        }

        Task<Response<string>> IReceita.RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
