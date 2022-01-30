namespace HT.Martian.Robots.Core.Interfaces.Models
{
    public class Coord
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coord() : this(0, 0)
        {
        }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
