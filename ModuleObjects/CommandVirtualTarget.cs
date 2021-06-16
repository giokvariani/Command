namespace Command.ModuleObjects
{
    public abstract class CommandVirtualTarget<TCommandTarget, TCommandCT, THTarget> : CommandTarget<TCommandTarget, TCommandCT, THTarget>
      where TCommandTarget : CommandVirtualTarget<TCommandTarget, TCommandCT, THTarget>
      where TCommandCT : CommandBase<TCommandTarget, TCommandCT, THTarget>
      where THTarget : ActualTarget<TCommandTarget, TCommandCT, THTarget>
    {
    }
}
