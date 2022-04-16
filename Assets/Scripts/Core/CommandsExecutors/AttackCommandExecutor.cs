using Abstractions.Commands;
using UnityEngine;

namespace Core.CommandsExecutors
{
    public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log($"Unit is attacking to {command.Target}!");
        }
    }
}


