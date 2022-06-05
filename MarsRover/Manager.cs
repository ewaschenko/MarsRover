using System.Collections.Generic;

namespace MarsRover
{
	public class Manager
	{
		List<Rover> rovers;
		Grid grid;
		int activeIndex = 0;

		public Manager(Grid grid)
		{
			rovers = new List<Rover>();
			this.grid = grid;
		}

		public void LaunchRover()
		{
			Coordinate location = new Coordinate(0, 0);

			if (grid.CanMove(location))
			{
				// Rover 1
				Rover rover = new Rover(new Coordinate(0, 0), Direction.N, grid, 1);
				rovers.Add(rover);

				// Rover 2
				Rover rover2 = new Rover(new Coordinate(0, 0), Direction.N, grid, 2);
				rovers.Add(rover2);
			}
			else
			{
				throw new Exception($"Cannot Launch Rover To {location}");
			}
		}

		public void MoveRover(Movement movement)
		{
			rovers[activeIndex].Move(movement);
			Console.WriteLine(rovers[activeIndex]);
			activeIndex = activeIndex >= rovers.Count() - 1 ? 0 : activeIndex + 1;
		}
	}
}
