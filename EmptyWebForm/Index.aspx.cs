using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxPro;

namespace EmptyWebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Utility.RegisterTypeForAjax(typeof(Index));
        }

        [AjaxMethod]
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}