#if (Northwind)
#endif

namespace Serene.Common.Pages;

[Route("PaginaProva/[action]")]
public class PaginaProva : Controller
{
    [PageAuthorize, HttpGet, Route("~/prova")]
#if (Northwind)
    public ActionResult Index([FromServices] ITwoLevelCache cache, [FromServices] ISqlConnections sqlConnections)
    {
        if (cache is null)
        	throw new System.ArgumentNullException(nameof(cache));

        if (sqlConnections is null)
        	throw new System.ArgumentNullException(nameof(sqlConnections));

        var o = Serenity.Demo.Northwind.OrderRow.Fields;

        var s = Serenity.Demo.Northwind.ShipperRow.Fields;

        var cachedModel = cache.GetLocalStoreOnly("DashboardDuePageModel", TimeSpan.FromMinutes(5),
            o.GenerationKey, () =>
            {
                var model = new DashboardDuePageModel();
                using (var connection = sqlConnections.NewFor<Serenity.Demo.Northwind.OrderRow>())
                {
                    //model.OpenOrders = connection.Count<Serenity.Demo.Northwind.OrderRow>(
                    //    o.ShippingState == (int)Serenity.Demo.Northwind.OrderShippingState.NotShipped);
                    //var closedOrders = connection.Count<Serenity.Demo.Northwind.OrderRow>(
                    //    o.ShippingState == (int)Serenity.Demo.Northwind.OrderShippingState.Shipped);
                    //var totalOrders = model.OpenOrders + closedOrders;
                    //model.ClosedOrderPercent = (int)Math.Round(totalOrders == 0 ? 100 :
                    //    ((double)closedOrders / totalOrders * 100));
                    //model.CustomerCount = connection.Count<Serenity.Demo.Northwind.CustomerRow>();
                    //model.ProductCount = connection.Count<Serenity.Demo.Northwind.ProductRow>();
                    //model.TotalOrders = totalOrders;

                    //model.Shippers = connection.Count<Serenity.Demo.Northwind.ShipperRow>();
                    //model.Employers = connection.Count<Serenity.Demo.Northwind.EmployeeRow>();
                    //model.Territories = connection.Count<Serenity.Demo.Northwind.TerritoryRow>();
                }
                return model;
            });
        //return View(MVC.Views.CommonDue.DashboardDue.DashboardDueIndex, cachedModel);
        return View(MVC.Views.ABC.Viste.PaginaProvaIndex, cachedModel);
    }
#else
    public ActionResult Index()
    {
        return View(MVC.Views.Common.Dashboard.DashboardIndex, new DashboardPageModel());
    }
#endif
}
