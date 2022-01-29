namespace HT.Martian.Robots.Core.Interfaces.ViewModels
{
    public class CoordViewModel
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public CoordViewModel() : this(0, 0)
        {
        }

        public CoordViewModel(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
