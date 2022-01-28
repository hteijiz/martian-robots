using HT.Martian.Robots.Core.ViewModels;
using System.Collections.Generic;

namespace HT.Martian.Robots.Core.Interfaces.ViewModels
{
    public class OrientationViewModel
    {
        private string currentOrientation;
        private IDictionary<string, Orientation> orientationMap = new Dictionary<string, Orientation>()
        {
            { "N", Orientation.North },
            { "E", Orientation.East },
            { "S", Orientation.South },
            { "W", Orientation.West }
        };
        private IDictionary<Orientation, string> orientationLetterMap = new Dictionary<Orientation, string>()
        {
            { Orientation.North, "N" },
            { Orientation.East, "E" },
            { Orientation.South, "S" },
            { Orientation.West, "W" }
        };

        public Orientation current { get; set; }

        public override string ToString()
        {
            return orientationLetterMap[current];
        }

        public OrientationViewModel(string orientation)
        {
            currentOrientation = orientation;
            current = orientationMap[orientation];
        }
    }
}
