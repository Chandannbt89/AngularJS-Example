using AngularJS_MVC.Models;
using SubSonic.Schema;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace AngularJS_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var menu = GetMenu();
            var vm = new ViewModel() { Menu = menu };
            return View(vm);
        }
        private Menu GetMenu()
        {
            StoredProcedure sp = new StoredProcedure("GetSiteMenu");
            DataTable dt = sp.ExecuteDataSet().Tables[0];

            var menu = new Menu();
            var menuItems = new List<MenuItem>();

            foreach (DataRow row in dt.Rows)
            {
                menuItems.Add(new MenuItem() { LinkText = row["Name"].ToString(), ActionName = row["url"].ToString(), ControllerName = "Home" });
                 
            }
           // menuItems.Add(new MenuItem() { LinkText = dt.Rows[0]["Name"].ToString (), ActionName = dt.Rows[0]["url"].ToString(), ControllerName = "Home" });
           // menuItems.Add(new MenuItem() { LinkText = "About", ActionName = "About", ControllerName = "Home" });
            //menuItems.Add(new MenuItem() { LinkText = "Help", ActionName = "Help", ControllerName = "Home" });
            menu.Items = menuItems;

            return menu;
        }

    }
}