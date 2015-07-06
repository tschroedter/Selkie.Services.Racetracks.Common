using Selkie.Services.Racetracks.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class RacetracksChangedMessage
    {
        public RacetracksDto Racetracks { get; set; }
    }
}