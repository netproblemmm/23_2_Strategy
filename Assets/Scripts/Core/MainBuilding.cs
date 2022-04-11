using Abstractions;
using Abstractions.Commands;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Transform PivotPoint => _pivotPoint;
        public Sprite Icon => _icon;

        [SerializeField] private Transform _pivotPoint;
        [SerializeField] private Transform _unitsParent;
        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;


        private float _health = 1000;

        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        {
            Instantiate(command.UnitPrefab,
                new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)),
                Quaternion.identity,
                _unitsParent);
        }
    }
}