
class Program
{
	static async Task<int> Method(SqlConnection conn, SqlCommand cmd)
	{
		await conn.OpenAsync();
		await cmd.ExecuteNonQueryAsync();
		return 1;
	}


	static int OtraOperacion(int numberOne, int numberTwo)
	{
		return numberOne + numberTwo;
	}

	static void Main(string[] args)
	{
		using (SqlConnection conn = new SqlConnection("Data Source=(local); Initial Catalog=NorthWind; Integrated Security=SSPI"))
		{
			SqlCommand command = new SqlCommand("select top 2 * from orders", conn);

			int result = 0;

			result = A.Method(conn, command).Result;

			Console.WriteLine("Resultado 1: " + result);

			Console.WriteLine("Resultado 2: " +  OtraOperacion(1, 2));
		}
	}
}


