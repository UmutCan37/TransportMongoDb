using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TransportMongoDb.Entities
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string QuestionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
