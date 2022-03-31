using Abstractions.Commands;
using UnityEngine;
using Utils;

namespace UserControlSystem
{
    public sealed class MoveCommand : IMoveCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Chomper")] private GameObject _unitPrefab;

        public void ExecuteCommand(IMoveCommand command)
        {

        }
    }
}
