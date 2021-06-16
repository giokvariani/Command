using CSharpFunctionalExtensions;
using System;

namespace Command.ModuleObjects
{
    public class PersonnelPenalty : CommandVirtualTarget<PersonnelPenalty, PenaltyCommand, ActualPenalty>
    {
        public PersonnelPenalty(Maybe<DateTime> dismissalDate, PenaltyTypeEnum penaltyTypeEnum)
        {
            DismissalDate = dismissalDate;
            PenaltyType = penaltyTypeEnum;
        }
        public Maybe<DateTime> DismissalDate { get; protected set; }
        public PenaltyTypeEnum PenaltyType { get; set; }

        public enum PenaltyTypeEnum
        {
            Reprimand = 0,
            Warning = 1,
            Dismissal = 2,
            OnlyDemonstrate
        }
        internal override void Validation()
        {
            base.Validation();
            //Do Something for Penalty
        }
    }
}
