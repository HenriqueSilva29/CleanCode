using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using backend.Utils;

namespace backend.Infrastructure.Data.MongoModels
{
    public class IngredienteReceitaDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ingredientes")]
        [JsonConverter(typeof(Conversor))]
        public Dictionary<string, Dictionary<string, string>> Ingredientes { get; set; }
    }
}
