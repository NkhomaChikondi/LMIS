using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace LMIS.API.Model
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ISBN { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("author")]
        public string Author { get; set; }
        [BsonElement("state")]
        public string State { get; set; }
        [BsonElement("obtained_Through")]
        public string Obtained_Through { get; set; }
        [BsonElement("publisher")]
        public string Publisher { get; set; }
        [BsonElement("genre")]
        public string Genrre { get; set; }
        [BsonElement("createdOn")]
        public BsonTimestamp CreatedOn { get; set; }       
    }
}
