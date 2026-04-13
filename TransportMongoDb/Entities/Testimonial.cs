using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TransportMongoDb.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ReviewDetail { get; set; }
        public int ReviewScore { get; set; }
        public bool Status { get; set; }
    }
}
