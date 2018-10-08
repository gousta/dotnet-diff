using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace DiffMongo.Models
{
  public class DataAccess
  {
    MongoClient _client;
    MongoServer _server;
    MongoDatabase _db;
  }
}