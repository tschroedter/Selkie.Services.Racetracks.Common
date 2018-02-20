using System;
using JetBrains.Annotations;
using Core2.Selkie.Services.Common.Dto;

namespace Core2.Selkie.Services.Racetracks.Common.Messages
{
    [UsedImplicitly]
    public class CostMatrixCalculateMessage
    {
        [UsedImplicitly]
        public Guid ColonyId;

        [UsedImplicitly]
        public bool IsPortTurnAllowed;

        [UsedImplicitly]
        public bool IsStarboardTurnAllowed;

        [NotNull]
        [UsedImplicitly]
        public LineDto[] LineDtos = new LineDto[0];

        [UsedImplicitly]
        public double TurnRadiusForPort;

        [UsedImplicitly]
        public double TurnRadiusForStarboard;
    }
}