using Abstractions.Commands;
using UnityEngine;

namespace Core.CommandsExecutors
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log($"Unit is patrolling!");
        }
    }
}

