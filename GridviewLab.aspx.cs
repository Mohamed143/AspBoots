using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBoots
{
    public partial class GridviewLab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Create List Collection
            List<Departments> dept = new List<Departments>()
            {
                new Departments{Dept_id = 01,Dept_name="IT",Dept_code="IT01"},
                new Departments{ Dept_id = 02, Dept_name = "CS", Dept_code="CS02"}
            };
            GridView1.DataSource = dept;
            GridView1.DataBind();
        }
    }
}