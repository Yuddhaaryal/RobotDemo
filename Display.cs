using System;
 namespace ReadText
{
    public class Display
    {
        public Position Position { get; set; }
        public void OutPosition(Robot robot)
        {
            var position = robot.Position;
            Console.WriteLine($"Active Robot:{robot.Name}");
            Console.WriteLine($"The resultung position: { position.PositionX}, {position.PositionY}, {position.Facing}");
        }
    }

}



