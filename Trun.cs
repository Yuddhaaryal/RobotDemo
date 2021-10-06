namespace ReadText
{
    public class Trun
    {
        private readonly Position _position;
        public Trun(Position position)
        {
            _position = position;
        }
        public Position Trun90(string command)
        {
            var currentFacing = _position.Facing;
            switch (command)
            {
                case "LEFT":
                    {
                        switch (currentFacing)
                        {
                            case "EAST":
                                currentFacing = "NORTH";
                                break;
                            case "NORTH":
                                currentFacing = "WEST";
                                break;
                            case "WEST":
                                currentFacing = "SOUTH";
                                break;
                            case "SOUTH":
                                currentFacing = "EAST";
                                break;
                        }
                        return new Position
                        {
                            PositionX = _position.PositionX,
                            PositionY = _position.PositionY,
                            Facing = currentFacing
                        };

                    }

                case "RIGHT":
                    {
                        switch (currentFacing)
                        {
                            case "EAST":
                                currentFacing = "SOUTH";
                                break;
                            case "NORTH":
                                currentFacing = "EAST";
                                break;
                            case "WEST":
                                currentFacing = "NORTH";
                                break;
                            case "SOUTH":
                                currentFacing = "WEST";
                                break;


                        }

                        return new Position
                        {
                            PositionX = _position.PositionX,
                            PositionY = _position.PositionY,
                            Facing = currentFacing
                        };
                    }

                default: return null;

            }



        }
    }
}


