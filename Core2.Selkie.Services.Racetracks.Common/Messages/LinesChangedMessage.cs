using JetBrains.Annotations;
using Core2.Selkie.Services.Common.Dto;

namespace Core2.Selkie.Services.Racetracks.Common.Messages
{
    public class LinesChangedMessage
    {
        [CanBeNull]
        public LineDto[] LineDtos { get; set; }
    }
}