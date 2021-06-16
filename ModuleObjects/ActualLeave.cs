namespace Command.ModuleObjects
{
    public class ActualLeave : ActualTarget<Leave, LeaveCommand, ActualLeave>
    {
        //I have to comment some parts of code because it is getting more hard, So i add property X
        public int X { get; set; }
    }
}
