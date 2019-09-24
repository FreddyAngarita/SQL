
class Program
{
	static async Task<int> Method(SqlConnection conn, SqlCommand cmd)
	{
		await conn.OpenAsync();
		await cmd.ExecuteNonQueryAsync();
		return 1;
	}


	static int anotherOperation(int numberOne, int numberTwo)
	{
		return numberOne + numberTwo;
	}

	static void Main(string[] args)
	{
		using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-O3RV5AC; Initial Catalog=WideWorldImporters; Integrated Security=SSPI"))
		{
			SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM Sales.Orders", conn);

			int result = 0;

			result = A.Method(conn, command).Result;

			Console.WriteLine("Resultado 1: " + result);

			Console.WriteLine("Resultado 2: " + anotherOperation(1, 2));
		}
	}
}


