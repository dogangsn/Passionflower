using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Passionflower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passionflower.Service
{
    public class MongoDbService
    {
        private readonly IMongoCollection<User> _user;

        public MongoDbService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("mongoDbCon"));
            var database = client.GetDatabase("LucyTable");
            _user = database.GetCollection<User>("Users");
        }

        public List<User> Get()
        {
            return _user.Find(user => true).ToList();
        }


        public User Create(User user)
        {
            _user.InsertOne(user);
            return user;
        }
    }
}
