using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void NewMessage(string text)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<SimpleHub>();
            context.Clients.All.newMessageReceived(new {foo = text});
        }

    }
}
