using Command.Interfaces;

namespace Command.ModuleObjects
{
    public abstract class CommandTarget<TCommandTarget, TCommandCT, THTarget>
    where TCommandTarget : CommandTarget<TCommandTarget, TCommandCT, THTarget>
    where TCommandCT : CommandBase<TCommandTarget, TCommandCT, THTarget>
    where THTarget : IAmTargetCharacteristic<TCommandTarget, TCommandCT, THTarget>
    {
        public TCommandCT Command { get; set; }
        public void SetCommand(TCommandCT command) => Command = command;
        internal virtual void Validation()
        {

        }

    }


}
