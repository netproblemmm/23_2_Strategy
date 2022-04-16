using Abstractions.Commands;
using UserControlSystem.CommandsRealization;
using Abstractions;

namespace UserControlSystem.UI.Model
{
    public sealed class AttackCommandCommandCreator : CancellableCommandCreatorBase<IAttackCommand, IAttackable>
    {
        protected override IAttackCommand CreateCommand(IAttackable argument) => new AttackCommand(argument);
    }
}
