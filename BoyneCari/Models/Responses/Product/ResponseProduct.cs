using MongoDB.Bson;
using System;

namespace BoyneCari.Models.Responses.Product
{
    public class ResponseProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
    }
}
