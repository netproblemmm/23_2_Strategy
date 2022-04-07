using Abstractions.Commands;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class PatrolCommand : IPatrolCommand
    {
        private Vector3 groundClick;

        public PatrolCommand(Vector3 groundClick)
        {
            this.groundClick = groundClick;
        }

        public void ExecuteCommand(IPatrolCommand command)
        {

        }
    }
}
