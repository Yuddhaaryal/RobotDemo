using System;
using System.Threading.Tasks;

namespace ReadText
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            string[] commands = System.IO.File.ReadAllLines("textdoc.txt");
            if (commands[0].Contains("PLACE"))
               {
                CommandFactory command = new CommandFactory();
                foreach (var commandText in commands)
                {
                    command.CreateCommand(commandText);
                }
            }
          
            Console.ReadKey();
            }
        }
    }


