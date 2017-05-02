using SubSonic.Schema;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace AngularJS_MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        //by Chandan
        public JsonResult GetSiteMenu()
        {
            StoredProcedure sp = new StoredProcedure("GetSiteMenu");
            DataTable dt = sp.ExecuteDataSet().Tables[0];

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return new JsonResult { Data = rows, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}