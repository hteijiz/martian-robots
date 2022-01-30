using HT.Martian.Robots.Core.Interfaces.Models;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IRobotService
    {
        string Handler(Enviroment env);
    }
}
