using System;
using System.Collections.Generic;
using System.Linq;
 namespace ReadText
{
    public class CommandFactory
    {
 
        Display d = new();
        public List<Robot> RobotList = new();
        public Robot ActiveRobot(List<Robot> robots)
        {
            
            foreach (Robot robot in robots)
            {
                if (robot.IsActive)
                
                    return robot;
                
              
            }
            return null;
        }

        public void CreateCommand(string commandText)
        {


           if (commandText.Contains("PLACE"))
            {
                if (RobotList != null)
                {
                    foreach (Robot robot in RobotList)
                    {
                        robot.IsActive = false;
                    }
                }
                var commandStrings = commandText.Split(" ");
                string[] parameters = commandStrings[1].Split(",");
                int xposition = int.Parse(parameters[0]);
                int yposition = int.Parse(parameters[1]);
                string facing = parameters[2];
                var position = new Position(xposition, yposition, facing);
                var count =RobotList.Count;
               RobotList.Add(new Robot 
                   { 
                   Name = $"ROBOT{count+1}" ,
                   IsActive = true,
                   Position = position
               }
               );

             


            }
            else if (commandText == "REPORT")
            {
                var activeRobot = ActiveRobot(RobotList);
                d.OutPosition(activeRobot);
            }
            else if (commandText.Contains("ROBOT"))
            {
                var activeRobot = ActiveRobot(RobotList);
                activeRobot.IsActive = false;
                foreach (var robot in RobotList)
                {
                    if (robot.Name == commandText)
                    {
                        robot.IsActive = true;
                    }
                    
                }
            }
            else if (commandText =="MOVE") { 
            }
                switch (commandText)                                        
                {
                    case "MOVE":
                        {
                            var activeRobot= ActiveRobot(RobotList);
                            Move move = new(activeRobot.Position);
                            activeRobot.Position = move.Reposition();
                            break;
                        }
                    case "LEFT" :
                        {
                            var activeRobot = ActiveRobot(RobotList);
                            Trun trun = new(activeRobot.Position);
                            activeRobot.Position = trun.Trun90(commandText);
                            break;
                        }
                    case "RIGHT":
                        {
                            var activeRobot = ActiveRobot(RobotList);
                            Trun trun = new(activeRobot.Position);
                            activeRobot.Position = trun.Trun90(commandText);
                            break;
                        }
                }


        }


    }

}



