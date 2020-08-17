using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalTest
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                PracticalTestBa obj = new PracticalTestBa();
                DataSet ds = new DataSet();
                string username = txtusername.Text;
                string password = txtpassword.Text;


                ds = obj.GetCredentials(username, password);
                if (ds.Tables.Count > 0)
                {
                    Response.Redirect("CandidateDetails.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Valid User Name and Password');", true);
                    
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
    }
}