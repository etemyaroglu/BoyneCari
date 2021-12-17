using BoyneCari.Attributes;
using BoyneCari.Data;
using BoyneCari.Models.Entities.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace BoyneCari.Models.Entities
{
    [BsonCollection("categories")]
    public class Category : IEntity
    {

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
 
    }
}
