using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SweetModel;

namespace SweetDAL
{
    public class Delete
    {
        SqlConnection? _conn;
        SqlCommand comm;
        public Delete()
        {
            _conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SweetIndia;Data Source=LAPTOP-TGUGO615\\SQLEXPRESS");
            _conn.Open();
        }
        public string DeleteSweetRecord(RetailModel retailModel)
        {
            return null;
        }
        public string DeleteSweetRecord(DisplayModel displayModel)
        {
            return null;
        }
        public string DeleteSweetRecord(MainModel mainModel)
        {
          
        
           
            try
            {
               comm=new SqlCommand("delete data from mainitems where item_code='"+mainModel.Item_Code+"'",_conn);
                comm.ExecuteNonQuery();
                return "REcord deleted";
            }
            catch(Exception expMsg)
            {
                return "Delete failed";
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}
