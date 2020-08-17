using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PracticalTest
{
    public class PracticalTestDA
    {
        private string connectionString;
        public PracticalTestDA()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PracticalTest"].ToString();
        }
       

       

        public int savedetails(string firstname,string lastname,string email,string mobileno,string city,string state,string country,string pincode,string photopath)
        {
            //DataSet ds = new DataSet();
            int x = 0;
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Save_CandidateDetails", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@firstname", SqlDbType.VarChar) { Value = firstname.ToString() });
                cmd.Parameters.Add(new SqlParameter("@lastname", SqlDbType.VarChar) { Value = lastname.ToString() });
                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar) { Value = email.ToString() });
                cmd.Parameters.Add(new SqlParameter("@mobileno", SqlDbType.VarChar) { Value = mobileno.ToString() });
                cmd.Parameters.Add(new SqlParameter("@city", SqlDbType.VarChar) { Value = city.ToString() });
                cmd.Parameters.Add(new SqlParameter("@state", SqlDbType.VarChar) { Value = state.ToString() });
                cmd.Parameters.Add(new SqlParameter("@country", SqlDbType.VarChar) { Value = country.ToString() });
                cmd.Parameters.Add(new SqlParameter("@pincode", SqlDbType.VarChar) { Value = pincode.ToString() });
                cmd.Parameters.Add(new SqlParameter("@photopath", SqlDbType.VarChar) { Value = photopath.ToString() });
                
                x=cmd.ExecuteNonQuery();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //sda.Fill(ds);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return x;
        }

        public DataSet GetCredentials(string username, string password)
        {
            DataSet ds = new DataSet();
            
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_CheckCredentials", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar) { Value = username.ToString() });
                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = password.ToString() });
                

                 cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet BindDetails()
        {
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_bindDetails", con);

                cmd.CommandType = CommandType.StoredProcedure;
                


                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(ds);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        

        public int SetPassword(string password, string ConfirmPassword, string Email)
        {
            //DataSet ds = new DataSet();
            int x = 0;
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_setUpPassoerd", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = password.ToString() });
                cmd.Parameters.Add(new SqlParameter("@ConfirmPassword", SqlDbType.VarChar) { Value = ConfirmPassword.ToString() });
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar) { Value = Email.ToString() });
                

                x = cmd.ExecuteNonQuery();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //sda.Fill(ds);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return x;
        }
    }
}