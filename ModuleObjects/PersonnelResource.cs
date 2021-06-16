namespace Command.ModuleObjects
{
    public class PersonnelResource
    {
        public PersonnelResource(Position position)
        {
            Position = position;
        }
        public Position Position { get; set; }
    }
}
