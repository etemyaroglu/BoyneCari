using BoyneCari.Attributes;
using BoyneCari.Data;
using BoyneCari.Models.Entities.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BoyneCari.Models.Entities
{
    [BsonCollection("Category")]
    public class Category : IEntity
    {

        [Required]
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
 
    }
}
