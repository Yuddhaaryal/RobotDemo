public class Position
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public string Facing { get; set; }
     public  Position(int x, int y, string facing)
    {
        PositionX = x;
        PositionY = y;
        Facing = facing;
    }

    public Position()
    {
    }
 
}


