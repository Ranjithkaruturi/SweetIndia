using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetModel;

namespace SweetDAL
{
    public class Update
    {
        SqlConnection? _conn;
        SqlCommand comm;
        public Update()
        {
            _conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SweetIndia;Data Source=LAPTOP-TGUGO615\\SQLEXPRESS");
            _conn.Open();
        }
        public string UpdateSweetRecord(DisplayModel displayModel)
        {
            return null;
        }
        public string UpdateSweetRecord(RetailModel retailModel)
        {
            return null;
        }


        public string UpdateSweetRecord(MainModel mainModel)
        {
           
            try
            {
                comm = new SqlCommand("update Sweet data set item_code='" + mainModel.Item_Code + "',item_name='" + mainModel.Item_Name + "'", _conn);
                comm.ExecuteNonQuery();
                return "Record Updated";
            }
            catch(Exception expMsg)
            {
                return "Update failed";
            }
            finally
            {
                _conn.Close();  
            }
        }
    }
}
