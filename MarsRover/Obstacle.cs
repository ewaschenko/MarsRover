namespace MarsRover
{
	public class Obstacle
	{
		public Coordinate location {get; private set;}

		public Obstacle(Coordinate location)
		{
			this.location = location;
		}
	}
}
