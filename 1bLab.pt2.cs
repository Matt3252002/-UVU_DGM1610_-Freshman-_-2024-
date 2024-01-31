using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("welcome");
		DoMath(10, 4);
		DoMath(20, 3);
		DoMath(30, 7);
	}
	
	public static void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	
	}
			
	
	
	
}