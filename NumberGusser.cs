using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace NumberGuessing 
{
	class Program 
	
	
	{
		static void Main(string[] args)
		{
		
			Random r = new Random();

			int winNum = r.Next(1, 10);

			bool win = false;

			do
			{
			
				Console.WriteLine("Guess a number between 1 and 10: ");
				string s = Console.WriteLine();

				int i = int.Parse(s);

				if (i > winNum) 
				{

					Console.WriteLine("Too high! Guess lower....");
				}
				else if (i < winNum)
				{
					Console.WriteLine("Too Low! Guess higher....");
				}
				else if (i == winNum)
				{
					Console.WriteLine("YOU WIN!");
					win = true;
				}
			
			} while (win == false);
		
		
		
		}
	
	}

}