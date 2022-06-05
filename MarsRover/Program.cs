using MarsRover;

// Rover Movement

/* X = Open Space
 * O = Obstacle
 * 
 *   O    X    X
 *   X    X    X
 *   X    X    O
 */

 // Both rovers should hit obstacle at (2,0), hit grid barrier at (1,3), hit obstacle at (0,2) and finsih at (0,0) S

string input = "RRMMMMLLMMMMMMLLMMLLMMMMRRMMLL";

Grid grid = Grid.GetInstance();
grid.AddObstacle(new Obstacle(new Coordinate(2, 0)));
grid.AddObstacle(new Obstacle(new Coordinate(0, 2)));

Manager manager = new Manager(grid);
manager.LaunchRover();

Parser.Parse(input, manager);
