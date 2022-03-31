namespace Abstractions.Commands
{
    public interface IAttackCommand : ICommand  
    {
        public abstract void ExecuteCommand(IAttackCommand command);
    }
}
