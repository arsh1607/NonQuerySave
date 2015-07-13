using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            SaveData sd = new SaveData();
            sd.DBSave("Name", "Phno", "Adress", "string");
        }        
    }

    public class SaveData
    {
       public SaveData() { }

        public void DBSave(string Name, string PhoneNo, string Address ,string connectionString)
        {            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Data (Name, PhoneNo, Address) VALUES (@Name, @PhoneNo, @Address)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                cmd.Parameters.AddWithValue("@Address", Address);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
