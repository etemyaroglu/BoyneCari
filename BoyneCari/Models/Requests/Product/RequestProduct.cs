using System;

namespace BoyneCari.Models.Requests.Product
{
    public class RequestProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
    }
}
