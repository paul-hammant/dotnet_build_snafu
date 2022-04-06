using Microsoft.AspNetCore.Mvc;

namespace DotNetPoC.Controllers
{
    public class HomeController : Controller
    {
        
        public ContentResult Index()
        {
            var contentResult = new ContentResult();
            // yes I know I coulda made a View cshtml
            contentResult.Content = "<html><head><title>hello</title></head><body>hello</body></html>";
            contentResult.ContentType = "text/html";
            return contentResult;
        }

    }
}