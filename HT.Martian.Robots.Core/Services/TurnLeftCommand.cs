using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;
using HT.Martian.Robots.Core.ViewModels;

namespace HT.Martian.Robots.Services
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute(RobotViewModel bot, EnviromentViewModel env)
        {
            bot.Orientation.current--;
            if (bot.Orientation.current < Orientation.North)
                bot.Orientation.current = Orientation.West;
        }
    }
}
