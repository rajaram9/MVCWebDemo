using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmptyMvc4.Controllers
{
    public class DocumentReceiveController : Controller
    {
        //
        // GET: /DocumentReceive/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult TodoList()
        {
            TodoListResult res = new TodoListResult();
            res.Id = 1;
            res.Name = "wilson.fu";
            return Json(res,JsonRequestBehavior.AllowGet);
        }


    }

    public class TodoListResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
