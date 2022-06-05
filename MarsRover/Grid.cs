using System.Linq;
using System.Collections.Generic;

namespace MarsRover
{
	public class Grid
	{
		Coordinate init;
		Coordinate topEdge;
		List<Obstacle> obstacles;
		private static Grid grid = null;

		private Grid()
		{
			init = new Coordinate(0, 0);
			topEdge = new Coordinate(2, 2);
			obstacles = new List<Obstacle>();
		}

		//Singleton Design Pattern
		public static Grid GetInstance()
		{
			if (grid == null)
			{
				grid = new Grid();
			}

			return grid;
		}

		public void SetTopEdge(Coordinate topEdge)
		{
			if (topEdge.x < 0 || topEdge.y < 0)
			{
				throw new Exception($"Invalid Coordinate {topEdge}");
			}

			this.topEdge = topEdge;
		}

		public void AddObstacle(Obstacle obstacle)
		{
			obstacles.Add(obstacle);
		}

		public bool CanMove(Coordinate location)
		{
			return InsideBoundary(location) && ClearPath(location);
		}

		public bool InsideBoundary(Coordinate location)
		{
			if (location.x >= init.x && location.x <= topEdge.x && location.y >= init.y && location.y <= topEdge.y)
			{
				return true;
			}
			else
			{
				Console.WriteLine($"Cannot Move To {location} Grid Barrier");
				return false;
			}
		}

		public bool ClearPath(Coordinate location)
		{
			if(!obstacles.Any(p => p.location.x == location.x && p.location.y == location.y))
			{
				return true;
			}
			else
			{
				Console.WriteLine($"Cannot Move To {location} Obstacle In The Way");
				return false;
				
			}
		}
	}
}
