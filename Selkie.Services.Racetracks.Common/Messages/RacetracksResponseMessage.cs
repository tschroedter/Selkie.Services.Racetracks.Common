using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class RacetracksResponseMessage
    {
        [NotNull]
        public RacetracksDto Racetracks = new RacetracksDto();
    }
}