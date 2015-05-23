namespace Selkie.Services.Racetracks.Common.Messages
{
    public class RacetrackSettingsChangedMessage
    {
        public bool IsPortTurnAllowed;
        public bool IsStarboardTurnAllowed;
        public double TurnRadiusInMetres;
    }
}