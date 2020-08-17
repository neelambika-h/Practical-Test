using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalTest
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDepartment();
            }

        }

        private void BindDepartment()
        {
            
            try
            {
                PracticalTestBa obj = new PracticalTestBa();

                DataSet ds = new DataSet();
                ds = obj.GetListOfProductNames();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    drpproductname.DataSource = ds;
                    drpproductname.DataTextField = "pruductname";
                    drpproductname.DataValueField = "pruductid";
                    drpproductname.DataBind();
                    drpproductname.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                
                
            }
            finally
            {

            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                PracticalTestBa obj = new PracticalTestBa();

                DataSet ds = new DataSet();
                string productname = drpproductname.SelectedValue;
                string QTY = txtqty.Text;
                string Rate = txtrate.Text;
                double pcost=Convert.ToDouble(Rate);
                string TotalValue = txttotal.Text;
                string CGST = txtcgst.Text;
                string SGST = txtsgst.Text;
                string IGST = txtigst.Text;
                double CGST_Amount = 0;
                double SGST_Amount = 0;
                double IGST_Amount = 0;
                double tax = 18;
                double taxableAmount = (pcost / 100) * tax;
                ds = obj.GetCompanyId(productname);
                int companyid = Convert.ToInt32(ds.Tables[0].Rows[0]["companyid"]);
                DataSet ds1 = new DataSet();
                ds1 = obj.GetCompanyState(companyid);
                string companyState = Convert.ToString(ds1.Tables[0].Rows[0]["statename"]);
                string CustomerState = Convert.ToString(txtState.Text);
                if (companyState.Equals(CustomerState))
                {
                    SGST_Amount = CGST_Amount = taxableAmount / 2;
                }
                else
                {
                    IGST_Amount = taxableAmount;
                }
                lbltAmount.Text = TotalValue;
                lblCGST.Text = Convert.ToString(CGST_Amount);
                lblSGDT.Text = Convert.ToString(SGST_Amount);
                lblIGST.Text = Convert.ToString(IGST_Amount);
                lblgtotal.Text = TotalValue + CGST_Amount + SGST_Amount + IGST_Amount;

                DataSet savedata = new DataSet();
                savedata = obj.savedetails(productname, QTY, Rate, TotalValue, CGST, SGST, IGST);
                
                    
                
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