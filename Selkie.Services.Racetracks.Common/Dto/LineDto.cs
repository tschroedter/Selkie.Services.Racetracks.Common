using JetBrains.Annotations;

namespace Selkie.Services.Racetracks.Common.Dto
{
    public class LineDto
    {
        public int Id;
        public bool IsUnknown;

        [NotNull]
        public string RunDirection = string.Empty;

        public double X1;
        public double X2;
        public double Y1;
        public double Y2;
    }
}