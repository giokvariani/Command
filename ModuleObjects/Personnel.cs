using Command.ModuleObjects;
using System.Collections.Generic;

namespace Command
{
    public class Personnel
    {
        public Personnel(string firstName, string lastName, IReadOnlyCollection<PersonnelResource> personnelResources)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonnelResources = personnelResources;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IReadOnlyCollection<PersonnelResource> PersonnelResources { get; set; }
    }
}
