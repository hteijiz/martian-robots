using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.Models;
using HT.Martian.Robots.Core.Models;

namespace HT.Martian.Robots.Services
{
    public class TurnRightCommand : ICommand
    {
        public void Execute(Robot bot, Enviroment env)
        {
            bot.Orientation.current++;
            if (bot.Orientation.current > Orientation.West)
                bot.Orientation.current = Orientation.North;
        }
    }
}
