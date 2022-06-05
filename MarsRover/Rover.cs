namespace MarsRover
{
	public class Rover
	{
		Coordinate location;
		Direction direction;
		Grid grid;
		int id;

		public Rover(Coordinate location, Direction direction, Grid grid, int id)
		{
			this.location = location;
			this.direction = direction;
			this.grid = grid;
			this.id = id;
		}

		public void Move(Movement movement)
		{
			switch (movement)
			{
				case Movement.M:
					MoveForward();
					break;
				case Movement.L:
					MoveLeft();
					break;
				case Movement.R:
					MoveRight();
					break;
				default:
					throw new Exception("Invalid Movement");
			}
		}

		public void MoveForward()
		{
			int newX = location.x;
			int newY = location.y;

			switch (direction)
			{
				case Direction.N:
					newY++;
					break;
				case Direction.E:
					newX++;
					break;
				case Direction.S:
					newY--;
					break;
				case Direction.W:
					newX--;
					break;
				default:
					throw new Exception("Invalid Direction");
			}

			if (grid.CanMove(new Coordinate(newX, newY)))
			{
				location.SetCoordinate(newX, newY);
			}
		}

		public void MoveLeft()
		{
			// Direction -> int, -90/+90 mod 360, int -> Direction

			//direction = (Direction)mod((int)direction - 90, 360)

			switch (direction)
			{
				case Direction.N:
					direction = Direction.W;
					break;
				case Direction.E:
					direction = Direction.N;
					break;
				case Direction.S:
					direction = Direction.E;
					break;
				case Direction.W:
					direction = Direction.S;
					break;
				default:
					throw new Exception("Invalid Direction");
			}
		}

		public void MoveRight()
		{
			switch (direction)
			{
				case Direction.N:
					direction = Direction.E;
					break;
				case Direction.E:
					direction = Direction.S;
					break;
				case Direction.S:
					direction = Direction.W;
					break;
				case Direction.W:
					direction = Direction.N;
					break;
				default:
					throw new Exception("Invalid Direction");
			}
		}

		public override string ToString()
		{
			return $"Rover {id} current coordinates are {location} and it is facing {direction.ToString()}";
		}
	}
}
