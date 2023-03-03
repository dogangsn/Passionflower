using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passionflower.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string userName { get; set; }
        public string passaword { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RecordDate { get; set; }
        public int Rol { get; set; }
    }
}
