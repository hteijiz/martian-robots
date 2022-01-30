namespace HT.Martian.Robots.Core.Interfaces.Models
{
    public class Robot
    {
        public Coord Coord
        {
            get;
            set;
        }
        public OrientationModel Orientation { get; set; }

        public string Instructions { get; set; }

        public bool IsLost { get; set; }

        public Robot(Coord coord,
            OrientationModel orientation,
            string instructions)
        {
            Coord = coord;
            Orientation = orientation;
            Instructions = instructions;
        }
    }
}
