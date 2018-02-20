using System;
using Core2.Selkie.Services.Common.Dto;
using JetBrains.Annotations;

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