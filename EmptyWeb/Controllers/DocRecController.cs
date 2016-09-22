using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EmptyWeb.Controllers
{
    public class DocRecController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PageName = "wilson.fu";
            ViewData["val"] = Session["val"];
            return View();
        }

        public JsonResult TodoList()
        {
            TodoListResult res = new TodoListResult();
            res.Id = 1;
            res.Name = "wilson.fu";
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GotoIndex()
        {
            Response.Redirect("~/DocRec/Index");
            return View();
        }
    }

    public class TodoListResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}