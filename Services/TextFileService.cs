using HT.Martian.Robots.Core.Interfaces.Services;
using HT.Martian.Robots.Core.Interfaces.ViewModels;
using System.Collections.Generic;

namespace HT.Martian.Robots.Services
{
    public class TextFileService : IFileService
    {
        public FileViewModel ReadFile(string file)
        {
            using (var fileReader = System.IO.File.OpenText(file))
            {
                var coordEnv = fileReader.ReadLine();

                var envCoordX = int.Parse(coordEnv.Split(' ')[0]);
                var envCoordY = int.Parse(coordEnv.Split(' ')[1]);

                var robots = new Dictionary<string, string>();
                while (!string.IsNullOrWhiteSpace(coordEnv))
                {
                    var robotKey = fileReader.ReadLine();
                    if (string.IsNullOrWhiteSpace(robotKey)) break;

                    var robotInstructions = fileReader.ReadLine();
                    if (string.IsNullOrWhiteSpace(robotInstructions)) break;

                    robots.TryAdd(robotKey, robotInstructions);
                }

                return new FileViewModel(
                    envCoordX,
                    envCoordY,
                    robots
                );
            }
        }
    }
}
