namespace PlaygroundKnockout.Web.Latests.Controllers
{
    using Microsoft.AspNet.Mvc;

    /// <summary>
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
