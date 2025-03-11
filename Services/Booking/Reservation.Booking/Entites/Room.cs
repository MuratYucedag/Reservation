using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Reservation.Booking.Entites
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
