// C# Refactor of the daily puzzle below. 
// Question has already been solved in JS. See main repo. 
// Currently, the various Console.WriteLines are for troubleshooting. 

using System;
using System.Diagnostics;
using System.Text;
using System.Numerics;

public class Program
{
	public static int Main()
	{
		int n = 1888897; // number to be calculated
		
		var answer = new StringBuilder();
		
		if (n == 0)
		{
			Console.WriteLine("n = 0 -> returning 1");
			answer.Append("1");
		}
		
		string binary = Convert.ToString(n, 2); // works to convert to binary
		
		string[] binaryArr = binary.Split('1');
		
		foreach (string bin in binaryArr)
		{
			Console.WriteLine(bin, bin.Length);
			if (bin.Length % 2 != 0 || bin.Length != 0)
			{
				Console.WriteLine(bin);
				Console.WriteLine("bin.Length was odd");
// 				return 1;
			}
			else if (bin.Length % 2 == 0 && bin.Length != 0)
			{
				Console.WriteLine(bin);
				Console.WriteLine("bin.Length was even");
			}
			else if (bin.Length == 0)
			{
				Console.WriteLine(bin);
				Console.WriteLine("bin.Length was 0");
			}
			else
			{
				Console.WriteLine(bin);
				Console.WriteLine("bin.Length error");
			}
		}
		
		//int[] binaryInts = new int[Convert.ToString(n, 2).Length];
		//string[] zeroInts = new string[binary.Split("1")];
		
		Console.WriteLine(answer);
		return 0;
	}
}
