using Command.ModuleObjects;

namespace Command
{
    public class PenaltyCommand : CommandBase<PersonnelPenalty, PenaltyCommand, ActualPenalty>
    {
        public PersonnelResource PersonnelResource { get; set; }
        public bool IsConfidential { get; protected set; }
    }
}
