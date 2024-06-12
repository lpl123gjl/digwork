using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect() 
        {
            string str = @"Data Source=二郭头;Initial Catalog=BookDao;Integrated Security=True";



            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql) 
        {

            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
