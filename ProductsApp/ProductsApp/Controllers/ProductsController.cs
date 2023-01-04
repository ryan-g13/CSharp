using ProductsApp.Models;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    [Route("api/[controller]/{id}")]
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Top Ramen", Category = "Groceries", Price = .33M },
            new Product { Id = 2, Name = "G I Joe", Category = "Toys", Price = 14.99M },
            new Product { Id = 3, Name = "Screw Driver", Category = "Tools", Price = 4.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            Console.WriteLine("Got to the controller correctly");
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product); 
        }
    }
}
