namespace MarsRover
{
	public class Coordinate
	{
		public int x { get; private set; }
		public int y { get; private set; }

		public Coordinate(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void SetCoordinate(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public override string ToString()
		{
			return $"({x.ToString()}, {y.ToString()})";
		}
	}
}
