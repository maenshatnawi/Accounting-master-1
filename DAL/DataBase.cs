using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DAL
{
    public class DataBase
    {
        
        private string connetionString = null;
        private SqlConnection connection;
        private SqlCommand command;
        public DataSet ExDatataBase_returnDataSet(SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connetionString = ConfigurationManager.AppSettings["con"].ToString();


            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand();
                command = cmd;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();


                return ds;
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            return ds;
        }

        public void ExDatataBase_nonQuery(SqlCommand cmd)
        {
            connetionString = ConfigurationManager.AppSettings["con"].ToString();


            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand();
                command = cmd;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch
            {

            }
        }

    }

}
