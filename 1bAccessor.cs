using System;
					
public class Program
{
	public Operations myOperator;
	
	public static void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 3);
		myOperator.DoMath(30, 7);
		myOperator.Comparison(4,3);
		myOperator.Comparison(3,4);
		myOperator.CheckPassword("StarFalcon25");
		myOperator.CheckPassword("Avengers12");
	}
	

	
}
public class Operations {
	
	
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