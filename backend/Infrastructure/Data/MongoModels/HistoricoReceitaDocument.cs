using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Infrastructure.Data.MongoModels
{
    public class HistoricoReceitaDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("dataReceita")]
        public DateTime DataReceita { get; set; }

        [BsonElement("receitaId")]
        public string ReceitaId { get; set; }  // Relacionamento via ID
    }
}
