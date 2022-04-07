using Abstractions.Commands;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class AttackCommand : IAttackCommand
    {
        private Vector3 groundClick;

        public AttackCommand(Vector3 groundClick)
        {
            this.groundClick = groundClick;
        }

        public void ExecuteCommand(IAttackCommand command)
        {
            
        }
    }
}
