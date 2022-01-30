using HT.Martian.Robots.Core.Interfaces.Models;

namespace HT.Martian.Robots.Core.Interfaces.Services
{
    public interface IEnviromentService
    {
        void Init(int x, int y);
        string ProcessInstructions(Robot bot);
    }
}
