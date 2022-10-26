namespace WebApiBasic.Models
{
    public class BaseProvider :IDisposable
    {
        AppDbContext context;
        protected AppDbContext Context
        {
            get
            {
                if(context == null)
                {
                    context = new AppDbContext();
                }
                return context;
            }
        }

        public void Dispose()
        {
            if(context != null)
            {
                context.Dispose();
            }
        }
    }
}
