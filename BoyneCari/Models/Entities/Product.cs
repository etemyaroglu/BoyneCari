using BoyneCari.Attributes;
using BoyneCari.Models.Entities.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoyneCari.Models.Entities
{
    [BsonCollection("Product")]
    public class Product : IEntity
    {  

        [Required]
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [Required]
        [BsonElement("categoryid")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        [Required]
        [BsonElement("price")]
        public double Price { get; set; }
        [Required]
        [BsonElement("currency")]
        public string Currency { get; set; }

        public virtual Category Category { get; set; }
      
    }
}
