using System.Collections.Generic;

namespace HT.Martian.Robots.Core.Interfaces.Models
{
    public class Enviroment
    {
        public Coord pointZero { get; set; }
        public Coord pointLimit { get; set; }

        public Enviroment(int x, int y)
        {
            pointZero = new Coord();
            pointLimit = new Coord(x, y);

            StopPointList = new List<Coord>();
        }

        public bool Contains(Coord coord)
        {
            return (coord.X >= pointZero.X
                && coord.Y >= pointZero.Y
                && coord.X <= pointLimit.X
                && coord.Y <= pointLimit.Y);
        }

        public IList<Coord> StopPointList { get; set; }
    }
}
