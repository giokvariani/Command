using Command.Interfaces;
using Command.ModuleObjects;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Command
{
    public abstract class CommandBase
    {
        public const string ListView = nameof(ListView);
        public const string ViewItem = nameof(ViewItem);
        public const string DetailView = nameof(DetailView);

        public static IReadOnlyCollection<Type> GetAllChild() =>
            Assembly.GetAssembly(typeof(CommandBase))
                .GetTypes()
                .Where(theType => theType.IsClass && !theType.IsAbstract && theType.IsSubclassOf(typeof(CommandBase)))
                .AsReadOnlyList();
        public string OrderNumber { get; set; }

        public int OrderNumberDigits { get; protected set; }

        public Personnel Personnel { get; protected set; }

        public DateTime OrderDate { get; protected set; }
    }

    public abstract class CommandBase<TCommandTarget, TCommandC, THTarget> : CommandBase
      where TCommandTarget : CommandTarget<TCommandTarget, TCommandC, THTarget>
      where TCommandC : CommandBase<TCommandTarget, TCommandC, THTarget>
      where THTarget : IAmTargetCharacteristic<TCommandTarget, TCommandC, THTarget>
    {
        public TCommandC CorrectedCommand { get; protected set; }

        public TCommandC SourceCommand { get; protected set; }

        public TCommandC ActiveCommand { get; set; }
        public TCommandTarget Target { get; set; }
        public TCommandC GetFirstFromCommandsFlow(Maybe<TCommandC> correctedCommand) =>
            correctedCommand.HasNoValue ? (TCommandC)this : correctedCommand.Value.SourceCommand == null ? correctedCommand.Value : CorrectedCommand.SourceCommand;
        internal void Validation()
        {
            Target.Validation();
        }

    }
}
