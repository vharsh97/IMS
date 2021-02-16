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

        private string[] productsData = new string[6];
        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); // Product ID
                        productsData[1] = dr[1].ToString(); // Product
                        productsData[2] = dr[2].ToString(); // Barcode
                        productsData[3] = dr[3].ToString(); // Selling price
                        productsData[4] = dr[4].ToString(); // Discount 
                        productsData[5] = dr[5].ToString(); // Final Selling Price
                    }
                }
                else
                {
                   
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }

        public void showProducts(DataGridView gv, DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn expiryGV, DataGridViewColumn categoryGV, DataGridViewColumn barcodeGV, DataGridViewColumn categoryIDGV)
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

        public void getListWithTwoParameters(string proc, ComboBox cb, string dispalyMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = dispalyMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn mPIDGV,DataGridViewColumn productIDGV, DataGridViewColumn productNameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                productIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                productNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Product data.", "Error", "Error");
            }
        }

        private object productStockCount = 0;
        public object getProductQuantity(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {
            }
            return productStockCount;
        }

        private bool checkPPExistance;
        public bool checkProductPriceExistance(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkPPExistance = true;
                }
                else
                {
                    checkPPExistance = false;
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return checkPPExistance;
        }
        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn availSGV, DataGridViewColumn totGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getALLStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                availSGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Stock data.", "Error", "Error");
            }
        }

        public void showProductWRTCategories(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn disGV, DataGridViewColumn profitPerGV )
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.showMSG("Unable to load Products.", "Error", "Error");
            }
        }

    }
}
