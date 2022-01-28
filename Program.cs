using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;
using HT.Martian.Robots.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HT.Martian.Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Join(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input\data.txt");

            IFileService fileService = new TextFileService();
            var fileViewModel = fileService.ReadFile(path);

            IEnviromentService envService = new EnviromentService();
            envService.Init(
                fileViewModel.coord.X,
                fileViewModel.coord.Y
                );

            var responses = new List<string>();
            foreach (var robot in fileViewModel.robots)
            {
                var botSplitted = robot.Key.Split(' ');
                var botCoordX = botSplitted[0];
                var botCoordY = botSplitted[1];
                var botOrientation = botSplitted[2];

                var response = envService.ProcessInstructions(
                    new RobotViewModel(new CoordViewModel(int.Parse(botCoordX), int.Parse(botCoordY)),
                    new OrientationViewModel(botOrientation),
                    robot.Value
                    ));

                responses.Add(response);

                Console.WriteLine(response);
            }

            Console.ReadLine();
        }
    }
}
