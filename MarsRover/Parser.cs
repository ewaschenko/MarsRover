namespace MarsRover
{
	public static class Parser
	{
		public static void Parse(string command, Manager manager)
		{
			foreach (char element in command)
			{
				Console.WriteLine($"Input: {element}");
				Movement movement;
				if (Enum.TryParse(element.ToString(), out movement))
				{
					manager.MoveRover(movement);
				}
				else
				{
					throw new Exception($"Invalid Movement {element}");
				}
			}
		}
	}
}
