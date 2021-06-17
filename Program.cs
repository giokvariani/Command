using Command.ModuleObjects;
using CSharpFunctionalExtensions;
using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            //Case 1
            var position = new Position("Back end developer");
            var personnelResource = new PersonnelResource(position);
            var personnelResources = new[] { personnelResource }.AsReadOnlyList();
            var personnel = new Personnel("Giorgi", "Kvariani", personnelResources);
            var leaveCommand = new LeaveCommand {Personnel = personnel, OrderNumber = "12/1შ"};
            var jun11 = new DateTime(2021, 6, 11);
            var jun18 = new DateTime(2021, 6, 18);
            leaveCommand.Target = new Leave(jun11, jun18, true);
            leaveCommand.Validation();

            //Case 2
            var penaltyCommand = new PenaltyCommand
            {
                Personnel = personnel,
                PersonnelResource = personnelResource,
                OrderNumber = "12/1დ",
                Target = new PersonnelPenalty(Maybe<DateTime>.None,
                    PersonnelPenalty.PenaltyTypeEnum.OnlyDemonstrate)
            };
            penaltyCommand.Validation();
        }
    }
}
