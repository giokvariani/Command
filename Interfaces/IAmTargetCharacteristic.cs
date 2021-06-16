using Command.ModuleObjects;

namespace Command.Interfaces
{
    public interface IAmTargetCharacteristic<TCommandTarget, TCommandC, THTarget>
       where TCommandTarget : CommandTarget<TCommandTarget, TCommandC, THTarget>
       where TCommandC : CommandBase<TCommandTarget, TCommandC, THTarget>
       where THTarget : IAmTargetCharacteristic<TCommandTarget, TCommandC, THTarget>
    {
        public TCommandTarget Value { get; set; }
    }
}
