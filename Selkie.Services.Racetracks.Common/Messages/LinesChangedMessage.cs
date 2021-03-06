﻿using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Racetracks.Common.Messages
{
    public class LinesChangedMessage
    {
        [CanBeNull]
        public LineDto[] LineDtos { get; set; }
    }
}