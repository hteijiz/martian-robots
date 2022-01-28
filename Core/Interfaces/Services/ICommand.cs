using HT.Martian.Robots.Core.Interfaces.ViewModels;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface ICommand
    {
        void Execute(RobotViewModel bot, EnviromentViewModel env);
    }
}
