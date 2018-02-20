using System;
using JetBrains.Annotations;
using Core2.Selkie.Services.Common.Dto;

namespace Core2.Selkie.Services.Racetracks.Common.Messages
{
    [UsedImplicitly]
    public class RacetracksResponseMessage
    {
        [UsedImplicitly]
        public Guid ColonyId;

        [NotNull]
        [UsedImplicitly]
        public RacetracksDto Racetracks = new RacetracksDto();
    }
}