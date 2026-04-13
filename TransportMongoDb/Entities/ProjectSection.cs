using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TransportMongoDb.Entities
{
    public class ProjectSection
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProjectSectionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
