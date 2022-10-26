using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBasic.Models;

namespace WebApiBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        [HttpGet]
        public List<Product> Get()
        {
            return provider.Product.GetProducts();
        }

        [HttpGet("getproductbyid/{id}")]
        public Product Get(int id)
        {
            return provider.Product.GetProductById(id);
        }

        [HttpPost]
        public int Create(Product obj)
        {
            return provider.Product.Create(obj);
        }

        [HttpPut]
        public int Update(Product obj)
        {
            return provider.Product.Update(obj);
        }

        [HttpDelete("delete/{id}")]
        public int Delete(int id)
        {
            return provider.Product.Delete(id);
        }
    }
}
