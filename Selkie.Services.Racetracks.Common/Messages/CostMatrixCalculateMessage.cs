using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class CostMatrixCalculateMessage
    {
        public bool IsPortTurnAllowed;
        public bool IsStarboardTurnAllowed;

        [NotNull]
        public LineDto[] LineDtos = new LineDto[0];

        public double TurnRadiusForPort;
        public double TurnRadiusForStarboard;
    }
}