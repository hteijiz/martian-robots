using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;
using HT.Martian.Robots.Core.ViewModels;

namespace HT.Martian.Robots.Services
{
    public class MoveForwardCommand : ICommand
    {
        public void Execute(RobotViewModel bot, EnviromentViewModel env)
        {
            var nextPosition = default(CoordViewModel);

            if (bot.Orientation.current == Orientation.North)
            {
                nextPosition = new CoordViewModel(bot.Coord.X, bot.Coord.Y + 1);
            }
            else if (bot.Orientation.current == Orientation.East)
            {
                nextPosition = new CoordViewModel(bot.Coord.X + 1, bot.Coord.Y);
            }
            else if (bot.Orientation.current == Orientation.South)
            {
                nextPosition = new CoordViewModel(bot.Coord.X, bot.Coord.Y - 1);
            }
            else if (bot.Orientation.current == Orientation.West)
            {
                nextPosition = new CoordViewModel(bot.Coord.X - 1, bot.Coord.Y);
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

        private bool isInMap(EnviromentViewModel env, CoordViewModel coord)
        {
            return env.Contains(coord);
        }
    }
}
