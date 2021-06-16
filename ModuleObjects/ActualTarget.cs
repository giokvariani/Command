using Command.Interfaces;
using System;

namespace Command.ModuleObjects
{
    public abstract class ActualTarget
    {
        public string SourceNumber { get; protected set; }
        public DateTime SourceDate { get; protected set; }
        public bool IsCanceled { get; protected set; }
        public void SetCancellation(bool value) => IsCanceled = value;
    }
    public abstract class ActualTarget<TCommandTarget, TCommandC, THTarget> : ActualTarget, IAmTargetCharacteristic<TCommandTarget, TCommandC, THTarget>
       where TCommandTarget : CommandTarget<TCommandTarget, TCommandC, THTarget>
       where TCommandC : CommandBase<TCommandTarget, TCommandC, THTarget>
       where THTarget : IAmTargetCharacteristic<TCommandTarget, TCommandC, THTarget>
    {
        public TCommandTarget Value { get; set; }
        public void SetTarget(TCommandTarget value) => Value = value;
        public virtual void InitializeValues(string sourceNumber, DateTime sourceDate, TCommandTarget target)
        {
            SourceNumber = sourceNumber;
            SourceDate = sourceDate;
            SetTarget(target);
        }
    }
}
