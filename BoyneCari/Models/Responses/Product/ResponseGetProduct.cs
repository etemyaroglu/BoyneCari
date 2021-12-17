using BoyneCari.Models.Responses.Category;

namespace BoyneCari.Models.Responses.Product
{
    public class ResponseGetProduct : ResponseProduct
    {
        public ResponseCategory Category { get; set; }
    }
}
