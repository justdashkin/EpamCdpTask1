using System.Collections.Generic;
using System.Data.SqlClient;


namespace Core
{
    public static class DbHelper
    {
        public static List<string> ListboxItems = new List<string>();

        public static List<int> GetDataFromDb()
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataProvider;Integrated Security=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            List<int> numbers = new List<int>();

            sql = "Select Number1, Number2 from Numbers";

            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                numbers.Add(int.Parse(dataReader.GetValue(0).ToString()));
                numbers.Add(int.Parse(dataReader.GetValue(1).ToString()));
            }

            cnn.Close();

            return numbers;
        }
    }
}
