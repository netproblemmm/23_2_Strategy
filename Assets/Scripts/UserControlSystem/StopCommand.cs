﻿using Abstractions.Commands;
using UnityEngine;
using Utils;

namespace UserControlSystem
{
    public sealed class StopCommand : IStopCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Chomper")] private GameObject _unitPrefab;

        public void ExecuteCommand(IStopCommand command)
        {

        }
    }
}
