using System;

public class Program
{
	public static void Main(string[] args)
	{
		int balls = 100;
		int ballsInBox = 3;

		int result = balls % ballsInBox;

		Console.WriteLine(result);
	}
}
