using MongoDB.Bson.Serialization.Attributes;

namespace Lykke.RabbitMq.Mongo.Deduplicator
{
    internal class MongoDuplicateEntity
    {
        [BsonId]
        public string BsonId { get; set; }

    }
}
