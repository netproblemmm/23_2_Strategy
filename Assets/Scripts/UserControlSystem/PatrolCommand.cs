using Abstractions.Commands;
using UnityEngine;
using Utils;

namespace UserControlSystem
{
    public sealed class PatrolCommand : IPatrolCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Chomper")] private GameObject _unitPrefab;

        public void ExecuteCommand(IPatrolCommand command)
        {

        }
    }
}
