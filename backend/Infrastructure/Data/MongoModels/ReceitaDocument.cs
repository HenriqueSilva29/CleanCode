using backend.Core.Enums;
using backend.Utils;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace backend.Infrastructure.Data.MongoModels
{
    /// <summary>
    /// Representa a estrutura da receita conforme armazenada no MongoDB.
    /// </summary>
    public class ReceitaDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("titulo")]
        public string? Titulo { get; set; }

        [BsonElement("Dificuldade")]
        public DificuldadeReceita Dificuldade { get; set; }

        [BsonElement("porcao")]
        public int PorcaoPessoas { get; set; }

        [BsonElement("ingredientes")]
        [JsonConverter(typeof(Conversor))]
        public Dictionary<string, Dictionary<string, string>> Ingredientes { get; set; }

        [BsonElement("preparo")]
        [JsonConverter(typeof(Conversor))]
        public Dictionary<string, Dictionary<string, string>> Preparo { get; set; }

        [BsonElement("observacao")]
        public string? Observacao { get; set; }
    }
}
