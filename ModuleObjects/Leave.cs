using System;

namespace Command.ModuleObjects
{
    public class Leave : CommandVirtualTarget<Leave, LeaveCommand, ActualLeave>
    {
        public Leave(DateTime startOn, DateTime endOn, bool isPayable)
        {
            StartOn = startOn;
            EndOn = endOn;
            IsPayable = isPayable;
        }

        public DateTime StartOn { get; protected set; }
        public DateTime EndOn { get; protected set; }
        public bool IsPayable { get; protected set; }
        internal override void Validation()
        {
            base.Validation();
            //Do Something for leave
        }
    }
}

