using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("welcome");
		DoMath(10, 4);
		DoMath(20, 3);
		DoMath(30, 7);
		Comparison(4,3);
		Comparison(3,4);
		CheckPassword("StarFalcon25");
		CheckPassword("Avengers12");
	}
	
	public static void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	
	}
			
	public static void Comparison (int value, int value2)
	{
		if(value > value2) {
			Console.WriteLine("True, the second is greater");
		} else {
			Console.WriteLine("False, the first is greater");
		}
	}
	public static void CheckPassword (string password) {
		if(password == "Avengers12" ) {
			Console.WriteLine("Correct");
		} else {
			Console.WriteLine("Incorrect");
		}
	}
	
}