using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(Index));
            if (!IsPostBack)
            {
                Session["val"] = DateTime.Now;
            }
        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            lblInfo.Text = DateTime.Now.ToString();
        }

        [AjaxPro.AjaxMethod]
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}