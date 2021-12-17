
using Microsoft.AspNetCore.Mvc;

namespace BoyneCari.Models.Requests.Category
{
    public class RequestCategoryFilter
    {
        [FromQuery]
        public string Name { get; set; }
    }
}
