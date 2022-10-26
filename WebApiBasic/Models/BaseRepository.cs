namespace WebApiBasic.Models
{
    public abstract class BaseRepository
    {
        protected AppDbContext context;
        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
