namespace WebApiBasic.Models
{
    public class ProductRepository:BaseRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        
        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public int Delete(int id)
        {
            context.Products.Remove(new Product { productId = id });
            return context.SaveChanges();
        }

        public int Create(Product obj)
        {
            context.Products.Add(obj);
            return context.SaveChanges();
        }

        public int Update(Product obj)
        {
            context.Products.Update(obj);
            return context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }
    }
}
