using System;
using System.Data;
using System.Data.SqlClient;

namespace Sql
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

                    SqlCommand cmd = new SqlCommand("EXECUTE dbo.SaleStockHoldingUpdates2 @StockItemTransactionID,@ItemId, @TransactionTypeID, @Quantity", con);
                    cmd.Parameters.AddWithValue("@StockItemTransactionID", 29984523);
                    cmd.Parameters.AddWithValue("@ItemId", 82);
                    cmd.Parameters.AddWithValue("@TransactionTypeID", 10);
                    cmd.Parameters.AddWithValue("@Quantity", 6);




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
