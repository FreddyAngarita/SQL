using System;
using System.Data;
using System.Data.SqlClient;

namespace sql
{
    class Program
    {

        static void Main(string[] args)
        {
            string cs = "Data Source=DESKTOP-O3RV5AC;Initial Catalog=WideWorldImporters; Integrated Security = True";
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    //Ejecutar procedimiento almacenado desde C#
                    SqlCommand cmd = new SqlCommand("EXECUTE SaleStockHoldingUpdates2 2998452,80, 10, 5", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        

        
    }
}
