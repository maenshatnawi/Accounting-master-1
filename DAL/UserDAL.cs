using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : DataBase
    {
        private SqlCommand cmd;

        public void D_Users_Insert(string UserName, string Password, string firstName, string midName, string lastName, string email, string address, string phoneNo)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Insert";
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@MidName", midName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_Users_Get()
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Get";

            return ExDatataBase_returnDataSet(cmd);
        }

        public void D_Users_Delete(int ID)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Delete";
            cmd.Parameters.AddWithValue("@id", ID);

            ExDatataBase_nonQuery(cmd);
        }

        public DataSet D_User_Edit(int ID)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Edit";
            cmd.Parameters.AddWithValue("@id", ID);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_User_Update(int ID, string UserName, string firstName, string midName, string lastName, string email, string address, string phoneNo)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Update";
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@MidName", midName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);

            ExDatataBase_nonQuery(cmd);
        }
        public DataSet D_Users_Login(string Username, string Password)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Login";
            cmd.Parameters.AddWithValue("@userName", Username);
            cmd.Parameters.AddWithValue("@password", Password);

            return ExDatataBase_returnDataSet(cmd);
        }

        public DataSet D_User_Check(int id)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Check";
            cmd.Parameters.AddWithValue("@id", id);

            return ExDatataBase_returnDataSet(cmd);
        }
        public void D_Users_Change_Password(int ID, string Password)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Change_Password";
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@password", Password);

            ExDatataBase_nonQuery(cmd);
        }
        public DataSet D_UsersList_Get(int id)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_UsersList_Get";
            cmd.Parameters.AddWithValue("@id", id);

            return ExDatataBase_returnDataSet(cmd);

        }
    }
}
