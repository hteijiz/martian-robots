using HT.Martian.Robots.Core.Interfaces.ViewModels;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IEnviromentService
    {
        void Init(int x, int y);
        string ProcessInstructions(RobotViewModel bot);
    }
}
