using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.ObjectModel;

namespace backend.Core.Entities
{
    public class Preparo
    {
        [BsonElement("descricao")]
        public string Descricao { get; set; }
    }
}
