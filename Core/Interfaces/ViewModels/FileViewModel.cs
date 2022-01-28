using System.Collections.Generic;

namespace HT.Martian.Robots.Core.Interfaces.ViewModels
{
    public class FileViewModel
    {
        public FileViewModel(int x, int y, IDictionary<string, string> _robots)
        {
            coord = new CoordViewModel(x, y);
            robots = _robots;
        }

        public CoordViewModel coord { get; private set; }
        public IDictionary<string, string> robots { get; private set; }
    }
}
