using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.Models;
using System.Collections.Generic;

namespace HT.Martian.Robots.Services
{
    public class RobotService : IRobotService
    {
        private Robot robot;
        public RobotService(Robot bot)
        {
            robot = bot;
        }

        private IDictionary<string, ICommand> actions = new Dictionary<string, ICommand>
        {
            { "L", new TurnLeftCommand() },
            { "R", new TurnRightCommand() },
            { "F", new MoveForwardCommand() }
        };

        public string Handler(Enviroment env)
        {
            if(string.IsNullOrWhiteSpace(robot.Instructions))
                return $"{robot.Coord.X} {robot.Coord.Y} {robot.Orientation} ZERO INST";

            if (robot.Instructions.Length > 100)
                return $"{robot.Coord.X} {robot.Coord.Y} {robot.Orientation} TOO MANY INST";

            foreach (var instruction in robot.Instructions)
            {
                if (robot.IsLost) break;

                actions[instruction.ToString()].Execute(robot, env);
            }

            return $"{robot.Coord.X} {robot.Coord.Y} {robot.Orientation} {(robot.IsLost ? "LOST" : "")}";
        }
    }
}
