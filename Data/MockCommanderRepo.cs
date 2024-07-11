using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data

{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Boil Kangkong", Line="Cut Kangkong", Platform="Knife & Chopping board"},
                new Command{Id=2, HowTo="Make iced coffee", Line="Get a teacup", Platform="Teacup & Spoon"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}