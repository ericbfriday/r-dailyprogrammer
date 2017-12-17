using System;
// using System.Diagnostics;
using System.Text;
// using System.Numerics;

public class Program
{
	public static void Main()
	{
		int n = 20; // number to be calculated
		
		var answer = new StringBuilder();
		
		if (n == 0)
		{
			Console.WriteLine("n = 0 -> returning 1");
			answer.Append("1 ");
			Console.WriteLine(answer);
			return;
		}
		
		for (int i = 0; i <= n; i++)
		{	
			if (i == 0)
			{
				answer.Append("1 ");
			}
			string binary = Convert.ToString(i, 2); 

			string[] binaryArr = binary.Split(new char[] {'1'}, StringSplitOptions.RemoveEmptyEntries);
			
			foreach (string bin in binaryArr)
			{
				if (i == 0)
				{
					break;
				}
				else if (bin.Length % 2 == 0 && i != 0)
				{
					answer.Append("1 ");
					break;
				}
				answer.Append("0 ");
			}
			Console.WriteLine(answer);
		}
		Console.WriteLine(answer);
	}
}
