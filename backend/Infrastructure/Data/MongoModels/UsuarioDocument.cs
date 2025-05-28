using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Infrastructure.Data.MongoModels
{
    public class UsuarioDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("senha")]
        public string Senha { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }
    }
}
