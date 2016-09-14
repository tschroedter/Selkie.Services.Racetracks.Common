using System;
using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
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