using Abstractions.Commands;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class StopCommand : IStopCommand
    {
        private Vector3 groundClick;

        public StopCommand(Vector3 groundClick)
        {
            this.groundClick = groundClick;
        }

        public void ExecuteCommand(IStopCommand command)
        {

        }
    }
}
