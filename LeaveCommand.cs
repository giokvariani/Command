using Command.ModuleObjects;

namespace Command
{
    public class LeaveCommand : CommandBase<Leave, LeaveCommand, ActualLeave>
    {
        public bool IsFromAnotherJob { get; set; }
    }
}
