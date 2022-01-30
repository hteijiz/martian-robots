using System.Collections.Generic;

namespace HT.Martian.Robots.Core.Interfaces.Models
{
    public class FileConfig
    {
        public FileConfig(int x, int y, IDictionary<string, string> _robots)
        {
            coord = new Coord(x, y);
            robots = _robots;
        }

        public Coord coord { get; private set; }
        public IDictionary<string, string> robots { get; private set; }
    }
}
