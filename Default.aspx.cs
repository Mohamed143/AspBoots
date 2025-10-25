using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspBoots
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgCover.ImageUrl = "/";
            imgCover.AlternateText = "No Image Uploaded";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = "C:\\Users\\Admin\\source\\repos\\AspBoots\\Uploads\\" + FileUpload1.FileName;
            
                try
                {
                    FileUpload1.SaveAs(path);
                    lblmessage.Text = $"File uploaded to {path}.<br>" +
                        $"File size is {FileUpload1.PostedFile.ContentLength}";
                }
                catch (DirectoryNotFoundException ex)
                {
                   lblmessage.Text = ex.Message;
                }
            }
        }
    }
}