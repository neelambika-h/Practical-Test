using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalTest
{
    public partial class CandidateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDetails();
            }
        }
       
        public void BindDetails()
        {
            try
            {
                PracticalTestBa obj = new PracticalTestBa();
                DataSet ds = new DataSet();

                ds = obj.BindDetails();
                gvImages.DataSource = ds;

                gvImages.DataBind();
                


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

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");

        }

    }
}