using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    class Retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passwordGV, DataGridViewColumn phoneGV, DataGridViewColumn emailGV, DataGridViewColumn statusGV, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUserData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void showCategories(DataGridView gv, DataGridViewColumn categoryIDGV, DataGridViewColumn categoryNameGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getCategoriesDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                categoryIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                categoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Categories data.", "Error", "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string dispalyMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);
                cb.DisplayMember = dispalyMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn expiryGV, DataGridViewColumn categoryGV, DataGridViewColumn priceGV, DataGridViewColumn barcodeGV, DataGridViewColumn categoryIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                categoryIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Product data.", "Error", "Error");
            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }

        private static string user_name=null, pass_word=null;
        private static bool checkLogin;

        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if(username != null && password != null)
                    {
                        if(user_name != username && pass_word == password)
                        {
                            MainClass.showMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.showMSG("Unable to login...", "Error", "Error");
            }
            return checkLogin;
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn companyNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                companyNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Suppliers data.", "Error", "Error");
            }
        }
    }
}
