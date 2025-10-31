using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBoots
{
    public partial class Controls4B : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name="Abdi hassan",Title="Manager" },
                new Employee() { Id = 2, Name="Mustafe hassan",Title="Engineer" },
                new Employee() { Id = 3, Name="Ali hassan",Title="Tester" }
            };
            employees.Add(new Employee() { });
            GridView1.DataSource = employees;
            GridView1.DataBind();
        }

        protected void Label1_PreRender(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = DropDownList2.SelectedItem.Value;
            if(id == "1")
            {
                txtname.Text = "Abdi Ali";
            }else if(id == "2")
            {
                txtname.Text = "Abdi Hassan";
            } else if(id == "3")
            {
                txtname.Text = "Mustafe Hassan";
            }
            else
            {
                txtname.Text = "Not found";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtname.Text = Calendar1.SelectedDate.ToString();
        }
    }
}