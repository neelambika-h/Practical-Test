using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalTest
{
    public partial class EnterPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Email"]= Server.UrlDecode(Request.QueryString["Parameter"].ToString());
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                PracticalTestBa obj = new PracticalTestBa();
                string password = txtpassword.Text;
                string ConfirmPassword = txtcofirmPassword.Text;
                string Email = Convert.ToString(Session["Email"]);
            
                
                int x = 0;
                if (password.Equals(ConfirmPassword))
                {
                    x = obj.SetPassword(password, ConfirmPassword, Email);
                    if (x > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Password Is Set');", true);
                        Response.Redirect("LoginPage.aspx");

                        return;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Something Went Wrong');", true);

                        return;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Enter Valid Password');", true);

                    return;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //
            }
           
        }
    }
}