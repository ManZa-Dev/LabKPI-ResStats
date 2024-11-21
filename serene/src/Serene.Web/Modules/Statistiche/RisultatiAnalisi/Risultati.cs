#if (Northwind)
#endif

namespace Serene.Common.Pages;

[Route("Risultati/[action]")]
public class Risultati : Controller
{
    [PageAuthorize, HttpGet, Route("~/risultati")]
#if (Northwind)
    public ActionResult Index([FromServices] ITwoLevelCache cache, [FromServices] ISqlConnections sqlConnections)
    {
        if (cache is null)
        	throw new System.ArgumentNullException(nameof(cache));

        if (sqlConnections is null)
        	throw new System.ArgumentNullException(nameof(sqlConnections));

        return View(MVC.Views.Statistiche.RisultatiAnalisi.RisultatiIndex);
    }
#else
    public ActionResult Index()
    {
        return View(MVC.Views.Common.Dashboard.DashboardIndex, new DashboardPageModel());
    }
#endif
}
