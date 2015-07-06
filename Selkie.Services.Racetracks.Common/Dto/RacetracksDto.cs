using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Dto
{
    public class RacetracksDto
    {
        [NotNull]
        public PathDto[][] ForwardToForward = new PathDto[0][];

        [NotNull]
        public PathDto[][] ForwardToReverse = new PathDto[0][];

        public bool IsUnknown;

        [NotNull]
        public PathDto[][] ReverseToForward = new PathDto[0][];

        [NotNull]
        public PathDto[][] ReverseToReverse = new PathDto[0][];
    }

    public class PathDto
    {
        [NotNull]
        public PointDto EndPoint = new PointDto();

        public bool IsUnknown;

        [NotNull]
        public PolylineDto Polyline = new PolylineDto();

        [NotNull]
        public PointDto StartPoint = new PointDto();
    }

    public class PointDto
    {
        public double X;
        public double Y;
    }

    public class PolylineDto
    {
        [NotNull]
        public SegmentDto[] Segments = new SegmentDto[0];
    }

    public class SegmentDto
    {
        [NotNull]
        public PointDto EndPoint = new PointDto();

        public bool IsUnknown;

        [NotNull]
        public PointDto StartPoint = new PointDto();

        [NotNull]
        public string Type = string.Empty;
    }

    public class ArcSegmentDto : SegmentDto
    {
        [NotNull]
        public CircleDto Circle = new CircleDto();

        [NotNull]
        public string TurnDirection = string.Empty;
    }

    public class LineSegmentDto : SegmentDto
    {
        [NotNull]
        public string RunDirection = string.Empty;
    }

    public class CircleDto
    {
        [NotNull]
        public PointDto CentrePoint = new PointDto();

        public bool IsUnknown;
        public double Radius;
    }
}