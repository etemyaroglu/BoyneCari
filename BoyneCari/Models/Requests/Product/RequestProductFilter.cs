using Microsoft.AspNetCore.Mvc;

namespace BoyneCari.Models.Requests.Product
{
    public class RequestProductFilter 
    {
        [FromQuery]
        public string Name { get; set; }
        [FromQuery]
        public string Description { get; set; }
    }
}
