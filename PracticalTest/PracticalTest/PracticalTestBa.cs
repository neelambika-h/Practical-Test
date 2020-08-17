using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PracticalTest
{
    public class PracticalTestBa
    {
        PracticalTestDA obj = null;

        

        

     

        public int savedetails(string firstname,string lastname,string email,string mobileno,string city,string state,string country,string pincode,string photopath)
        {
           // DataSet ds = new DataSet();
            int x = 0;
            obj = new PracticalTestDA();
            try
            {
                x = obj.savedetails(firstname, lastname, email, mobileno, city, state, country, pincode, photopath);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //
            }
            return x;
        }

        public DataSet GetCredentials(string username, string password)
        {
             DataSet ds = new DataSet();
            
            obj = new PracticalTestDA();
            try
            {
                ds = obj.GetCredentials(username,password);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //
            }
            return ds;
        }

        public DataSet BindDetails()
        {
              DataSet ds = new DataSet();
            
            obj = new PracticalTestDA();
            try
            {
                ds = obj.BindDetails();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //
            }
            return ds;
        }

        public int SetPassword(string password, string ConfirmPassword, string Email)
        {
            // DataSet ds = new DataSet();
            int x = 0;
            obj = new PracticalTestDA();
            try
            {
                x = obj.SetPassword(password, ConfirmPassword, Email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //
            }
            return x;
        }
    }
}