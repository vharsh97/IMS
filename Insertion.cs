using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Insertion
    {
        public void insertUser(string name, string username, string password, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pwd",password);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " added to the system successfully", "Success...", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " added to the system successfully", "Success...", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }

        public void insertProduct(string product, string barcode, float price, int catID, DateTime? expiry)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                if(expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(product + " added to the system successfully", "Success...", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
