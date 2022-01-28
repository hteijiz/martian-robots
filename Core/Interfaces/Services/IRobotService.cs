using HT.Martian.Robots.Core.Interfaces.ViewModels;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IRobotService
    {
        string Handler(EnviromentViewModel env);
    }
}
