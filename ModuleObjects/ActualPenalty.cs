namespace Command.ModuleObjects
{
    public class ActualPenalty : ActualTarget<PersonnelPenalty, PenaltyCommand, ActualPenalty>
    {
        //I have to comment some parts of code because it is getting hard, So i add property Y
        public int Y { get; set; }
    }
}
