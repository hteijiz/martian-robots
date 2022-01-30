using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.Models;
using HT.Martian.Robots.Core.Models;

namespace HT.Martian.Robots.Services
{
    public class MoveForwardCommand : ICommand
    {
        public void Execute(Robot bot, Enviroment env)
        {
            var nextPosition = default(Coord);

            if (bot.Orientation.current == Orientation.North)
            {
                nextPosition = new Coord(bot.Coord.X, bot.Coord.Y + 1);
            }
            else if (bot.Orientation.current == Orientation.East)
            {
                nextPosition = new Coord(bot.Coord.X + 1, bot.Coord.Y);
            }
            else if (bot.Orientation.current == Orientation.South)
            {
                nextPosition = new Coord(bot.Coord.X, bot.Coord.Y - 1);
            }
            else if (bot.Orientation.current == Orientation.West)
            {
                nextPosition = new Coord(bot.Coord.X - 1, bot.Coord.Y);
            }

            if (env.StopPointList.Contains(nextPosition))
            {
                return;
            }

            if (!isInMap(env, nextPosition))
            {
                env.StopPointList.Add(nextPosition);
                bot.IsLost = true;
            }
            else
            {
                bot.Coord = nextPosition;
            }
        }

        private bool isInMap(Enviroment env, Coord coord)
        {
            return env.Contains(coord);
        }
    }
}
