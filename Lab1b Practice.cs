using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("welcome");
		DoMath(10);
		DoMath(20);
		DoMath(30);
	}
	
	public static void DoMath(int value)
	{
		var number = value + 4;
		Console.WriteLine(number);
	
	}
			
	
	
	
}