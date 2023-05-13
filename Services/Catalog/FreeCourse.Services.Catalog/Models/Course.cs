using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace FreeCourse.Services.Catalog.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        public string Name { get; set; }
        public string UserId { get; set; } // Kursu verenin User Id'si
        public string Picture { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public Feature Feature { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }
    }
}
