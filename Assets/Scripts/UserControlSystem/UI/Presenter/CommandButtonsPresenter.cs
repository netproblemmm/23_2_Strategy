using Abstractions;
using Abstractions.Commands;
using System;
using System.Collections.Generic;
using UnityEngine;
using UserControlSystem;
using Utils;

namespace Presenter
{
    public class CommandButtonsPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectable;
        [SerializeField] private CommandButtonsView _view;
        [SerializeField] private AssetsContext _context;

        private ISelectable _currentSelectable;

        private void Start()
        {
            _selectable.OnSelected += onSelected;
            onSelected(_selectable.CurrentValue);
            _view.OnClick += onButtonClick;
        }
        private void onSelected(ISelectable selectable)
        {
            if (_currentSelectable == selectable)
                return;
            _currentSelectable = selectable;

            _view.Clear();
            if (selectable != null)
            {
                var commandExecutors = new List<ICommandExecutor>();
                commandExecutors.AddRange((selectable as Component).GetComponentsInParent<ICommandExecutor>());
                _view.MakeLayout(commandExecutors);
            }
        }

        private void onButtonClick(ICommandExecutor commandExecutor)
        {
            var unitProducer = commandExecutor as CommandExecutorBase<IProduceUnitCommand>;
            if (unitProducer != null)
            {
                unitProducer.ExecuteSpecificCommand(_context.Inject(new ProduceUnitCommand()));
                return;
            }

            var attackUnit = commandExecutor as CommandExecutorBase<IAttackCommand>;
            if (attackUnit != null)
            {
                attackUnit.ExecuteSpecificCommand(_context.Inject(new AttackCommand()));
                return;
            }

            var moveUnit = commandExecutor as CommandExecutorBase<IMoveCommand>;
            if (moveUnit != null)
            {
                moveUnit.ExecuteSpecificCommand(_context.Inject(new MoveCommand()));
                return;
            }

            var patrolUnit = commandExecutor as CommandExecutorBase<IPatrolCommand>;
            if (patrolUnit != null)
            {
                patrolUnit.ExecuteSpecificCommand(_context.Inject(new PatrolCommand()));
                return;
            }

            var stopUnit = commandExecutor as CommandExecutorBase<IStopCommand>;
            if (stopUnit != null)
            {
                stopUnit.ExecuteSpecificCommand(_context.Inject(new StopCommand()));
                return;
            }

            throw new ApplicationException($"{nameof(CommandButtonsPresenter)}.{nameof(onButtonClick)}: " +
                                           $"Unknown type of commands executor: {commandExecutor.GetType().FullName}!");
        }
    }
}
