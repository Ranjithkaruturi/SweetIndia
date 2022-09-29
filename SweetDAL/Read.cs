using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetModel;
using System.Data;

namespace SweetDAL
{
    public class Read
    {
        SqlConnection? _conn;
        SqlCommand? comm;
        SqlDataReader? SqlDR;
        public Read()
        {
            List<MainModel> list = new List<MainModel>();
            _conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SweetIndia;Data Source=LAPTOP-TGUGO615\\SQLEXPRESS");
            _conn.Open();
        }
        public List<MainModel> GetSweetData2()
        {
            List<MainModel> list = new List<MainModel>();
            try
            {
                comm = new SqlCommand("select item_code,item_name from mainitems order by item_code desc", _conn);
                SqlDR = comm.ExecuteReader();
                return list;
            }
            catch (Exception)
            {
                return list;
            }
        }
        public List<DisplayModel> GetSweetData1()
        {
            List<DisplayModel> list = new List<DisplayModel>();
            try
            {
                comm = new SqlCommand("select item_code,mainitem,name from displayitemsorder by item_code desc", _conn);
                SqlDR = comm.ExecuteReader();
                return list;
            }
            catch (Exception)
            {
                return list;
            }
        }
            public List<RetailModel> GetSweetData()
            {
                List<RetailModel> list = new List<RetailModel>();
                try
                {

                    comm = new SqlCommand("select item_code,displayitem,name from retailitems order by item_code desc", _conn);
                    SqlDR = comm.ExecuteReader();
                    return list;
                }
                catch (Exception expMsg)
                {
                    return list;
                }
                finally
                {
                    _conn.Close();
                }
            }
        }
    }
