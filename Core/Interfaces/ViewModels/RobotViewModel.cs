namespace HT.Martian.Robots.Core.Interfaces.ViewModels
{
    public class RobotViewModel
    {
        public CoordViewModel Coord
        {
            get;
            set;
        }
        public OrientationViewModel Orientation { get; set; }

        public string Instructions { get; set; }

        public bool IsLost { get; set; }

        public RobotViewModel(CoordViewModel coord,
            OrientationViewModel orientation,
            string instructions)
        {
            Coord = coord;
            Orientation = orientation;
            Instructions = instructions;
        }
    }
}
