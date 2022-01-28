using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;

namespace HT.Martian.Robots.Services
{
    public class EnviromentService : IEnviromentService
    {
        private EnviromentViewModel Enviroment { get; set; }

        public void Init(int x, int y)
        {
            Enviroment = new EnviromentViewModel(x, y);
        }

        public string ProcessInstructions(RobotViewModel bot)
        {
            IRobotService robotService = new RobotService(bot);

            var response = robotService.Handler(Enviroment);

            return response;
        }
    }
}
