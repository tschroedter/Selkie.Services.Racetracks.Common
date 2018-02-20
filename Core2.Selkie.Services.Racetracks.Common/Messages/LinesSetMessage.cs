using JetBrains.Annotations;
using Core2.Selkie.Services.Common.Dto;

namespace Core2.Selkie.Services.Racetracks.Common.Messages
{
    public class LinesSetMessage
    {
        [CanBeNull]
        public LineDto[] LineDtos { get; set; }
    }
}