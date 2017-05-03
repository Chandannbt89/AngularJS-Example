using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJS_MVC.Models
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
    }
    public class MenuItem
    {
        public string LinkText { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    }
}