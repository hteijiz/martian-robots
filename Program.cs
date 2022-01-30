using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.Models;
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
            try
            {
                var path = Path.Join(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input\data.txt");
                IFileService fileService = new TextFileService();
                var file = fileService.ReadFile(path);

                IEnviromentService envService = new EnviromentService();
                envService.Init(
                    file.coord.X,
                    file.coord.Y
                    );

                var responses = new List<string>();
                foreach (var robot in file.robots)
                {
                    var botSplitted = robot.Key.Split(' ');
                    var botCoordX = botSplitted[0];
                    var botCoordY = botSplitted[1];
                    var botOrientation = botSplitted[2];

                    var response = envService.ProcessInstructions(
                        new Robot(new Coord(int.Parse(botCoordX), int.Parse(botCoordY)),
                        new OrientationModel(botOrientation),
                        robot.Value
                        ));

                    responses.Add(response);

                    Console.WriteLine(response);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
