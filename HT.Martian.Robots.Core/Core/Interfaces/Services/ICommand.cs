using HT.Martian.Robots.Core.Interfaces.Models;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface ICommand
    {
        void Execute(Robot bot, Enviroment env);
    }
}
