using Abstractions.Commands;
using UnityEngine;
using Utils;

namespace UserControlSystem
{
    public sealed class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Chomper")] private GameObject _unitPrefab;

    }
}
