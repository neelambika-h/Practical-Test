using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalTest
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }
        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image control.
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);
        }

       

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                PracticalTestBa obj = new PracticalTestBa();

                DataSet ds = new DataSet();
                string photopath =Image1.ImageUrl;
                string firstname =txtfirstname.Text;
                string lastname = txtlastname.Text;
                string email = txtEmail.Text;
                string mobileno = txtMobileNo.Text;
                string city = txtcity.Text;
                string state = txtstate.Text;
                string country = txtcountry.Text;
                string pincode = txtpincode.Text;

                int x = 0;
                //DataSet savedata = new DataSet();
                x = obj.savedetails(firstname,lastname,email,mobileno,city,state,country,pincode,photopath);
                if (x > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Details Saved successfully');", true);
                    Response.Redirect("EnterPasswordPage.aspx?Parameter=" + Server.UrlEncode(txtEmail.Text));
                    clear();
                    return;
                }


            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
        }
        public void clear()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtEmail.Text = "";
            txtMobileNo.Text = "";
            txtcity.Text = "";
            txtstate.Text = "";
            txtcountry.Text = "";
            txtpincode.Text = "";
            
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}