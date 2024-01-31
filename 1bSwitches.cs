using System;
					
public class Program
{
	
	public	GameStates gameStates;
	
	public static void Main()
	{
		gameStates = new GameStates();
		Console.WriteLine("Hello World");
	}
}
public class GameStates
{
	public enum States{
		Starting,
		Playing,
		Ending
		
	}
		
	public States currentState = States.Starting;
	
	
	public static void GameState () {
		switch (currentState){
			case States.Starting:
				Console.WriteLine("Starting");
				break;
		}
	}
}