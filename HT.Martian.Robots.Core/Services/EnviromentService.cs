using HT.Martian.Robots.Core.Core.Models.Exceptions;
using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;
using System;

namespace HT.Martian.Robots.Services
{
    public class EnviromentService : IEnviromentService
    {
        private EnviromentViewModel Enviroment { get; set; }

        public void Init(int x, int y)
        {
            if (x == 0 && y == 0)
                throw new FailInitEnvException("Fail: Coord (0,0) is invalid");
            if (x <= 0)
                throw new FailInitEnvException("Fail: Coord X must be greather than zero");
            if (y <= 0)
                throw new FailInitEnvException("Fail: Coord Y must be greather than zero");

            Enviroment = new EnviromentViewModel(x, y);
        }

        public string ProcessInstructions(RobotViewModel bot)
        {
            if (bot == null)
                throw new ArgumentNullException("bot");

            IRobotService robotService = new RobotService(bot);

            var response = robotService.Handler(Enviroment);

            return response;
        }
    }
}
