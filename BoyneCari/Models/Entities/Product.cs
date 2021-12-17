using BoyneCari.Attributes;
using BoyneCari.Models.Entities.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoyneCari.Models.Entities
{
    [BsonCollection("products")]
    public class Product : IEntity
    {  

        [Required]
        [Column("name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Currency { get; set; }
      
    }
}
