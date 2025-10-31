using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBoots
{
    public partial class PageDirec4F : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Departments> list = new List<Departments>()
            {
                new Departments {Dept_id = 01, Dept_name="IT", Dept_code="IT01"}
            };
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Label1_PreRender(object sender, EventArgs e)
        {
            Label1.Text = "Not Set";
        }
    }
}