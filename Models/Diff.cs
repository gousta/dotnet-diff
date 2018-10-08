using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DiffMongo.Models
{
  public class Diff
  {
    [BsonId]
    public ObjectId Id { get; set; }
    public int DiffId { get; set; }
    public string Left { get; set; }
    public string Right { get; set; }
  }
}