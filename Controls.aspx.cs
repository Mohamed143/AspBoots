using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBoots
{
    public partial class Controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Students> students = new List<Students>(
                new Students[]
                {
                    new Students() { StudentId = 1, StudentName = "John", Age = 18 },
                    new Students() { StudentId = 2, StudentName = "Mary", Age = 19 },
                    new Students() { StudentId = 3, StudentName = "Steve", Age = 20 },
                    new Students() { StudentId = 4, StudentName = "Sara", Age = 21 },
                    new Students() { StudentId = 5, StudentName = "Abdi", Age = 22 }
                }
                );
            GridView1.DataSource = students;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}