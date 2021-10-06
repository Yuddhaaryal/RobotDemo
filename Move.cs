using System.Collections.Generic;
 namespace ReadText
{
    public class Move

    {
        private const int MAX = 4;
        private readonly Position _placeCommand;
        
        public Move(Position position)
        {
            _placeCommand = position;
           

        }

        public Position Reposition()
        {
            var x = _placeCommand.PositionX;
            var y = _placeCommand.PositionY;
            var f = _placeCommand.Facing;
            if (x <= 0 && f == "WEST" ||
                x >= MAX && f == "EAST" ||
                y <= 0 && f == "SOUTH" ||
                y >= MAX && f == "NORTH")
            {
                return _placeCommand;

            }
            else
                switch (f)
                {
                    case "NORTH":
                        _placeCommand.PositionY = y + 1;
                        break;
                    case "SOUTH":
                        _placeCommand.PositionY = y - 1;
                        break;
                    case "EAST":
                        _placeCommand.PositionX = x + 1;
                        break;

                    case "WEST":
                        _placeCommand.PositionX = x - 1;
                        break;

                }
            return new Position
            {
                PositionX = _placeCommand.PositionX,
                PositionY = _placeCommand.PositionY,
                Facing = f
            };



        }


    }




}
