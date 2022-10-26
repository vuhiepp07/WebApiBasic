using Microsoft.AspNetCore.Mvc;
using WebApiBasic.Models;

namespace WebApiBasic.Controllers
{
    public abstract class BaseController : ControllerBase, IDisposable
    {
        protected SiteProvider provider = new SiteProvider();
        public void Dispose()
        {
            provider.Dispose();
        }
    }
}
