using System.Collections.Generic;

namespace HT.Martian.Robots.Core.Interfaces.ViewModels
{
    public class EnviromentViewModel
    {
        public CoordViewModel pointZero { get; set; }
        public CoordViewModel pointLimit { get; set; }

        public EnviromentViewModel(int x, int y)
        {
            pointZero = new CoordViewModel();
            pointLimit = new CoordViewModel(x, y);

            StopPointList = new List<CoordViewModel>();
        }

        public bool Contains(CoordViewModel coord)
        {
            return (coord.X >= pointZero.X
                && coord.Y >= pointZero.Y
                && coord.X <= pointLimit.X
                && coord.Y <= pointLimit.Y);
        }

        public IList<CoordViewModel> StopPointList { get; set; }
    }
}
