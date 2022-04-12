using Microsoft.AspNetCore.Mvc;
using Violent.Fairy.Domain.Catalog;
using Violent.Fairy.Data;

namespace Violent.Fairy.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
        }
    }
}        
