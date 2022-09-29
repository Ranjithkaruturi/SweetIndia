using SweetModel;
using System.Data.SqlClient;
using System.Data;
namespace SweetDAL
{
    public class ADD
    {
        SqlConnection? _conn;
        SqlCommand? comm;

        public ADD()
        {
            _conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SweetIndia;Data Source=LAPTOP-TGUGO615\\SQLEXPRESS");
            _conn.Open();
        }
        public string AddSweetRecord(RetailModel retailModel)
        {
            return null;
        }
        public string AddSweetRecord(DisplayModel displayModel)
        {
            return null;
        }
        public string AddSweetRecord(MainModel mainModel)
        {
            try
            {
                comm = new SqlCommand("Insert into mainitems (item_code,item_name) values('" + mainModel.Item_Code + "','" + mainModel.Item_Name + "')", _conn);
                comm.ExecuteNonQuery();
                return "record inserted succesfully";
            }
            catch (Exception expMsg)
            {
                return "record insert failed";
            }
            finally
            {
                _conn.Close();
            }

        }

    }
}