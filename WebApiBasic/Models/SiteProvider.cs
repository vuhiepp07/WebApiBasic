namespace WebApiBasic.Models
{
    public class SiteProvider:BaseProvider
    {
        ProductRepository product;
        public ProductRepository Product
        {
            get
            {
                if(product == null)
                {
                    product = new ProductRepository(Context);
                }
                return product;
            }
        }
    }
}
