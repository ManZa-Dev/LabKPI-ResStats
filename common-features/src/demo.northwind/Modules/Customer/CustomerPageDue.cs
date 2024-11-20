using Microsoft.AspNetCore.Mvc;

namespace Serenity.Demo.Northwind;

[PageAuthorize(typeof(CustomerRow))]
public class CustomerPageDue : Controller
{
    [Route("Northwind/CustomerDue")]
    public ActionResult Index()
    {
        return this.GridPage<CustomerRow>(ESM.CustomerPage);
    }
}

[Obsolete("Use CustomerPageDue")]
public abstract class CustomerDueController : CustomerPageDue
{
}
