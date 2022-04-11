using System;
using UnityEngine;

namespace Abstractions
{
    public abstract class ScriptableObjectValueBase<T>: ScriptableObject
    {
        public T CurrentValue { get; private set; }
        public event Action<T> OnNewValue;

        public void SetValue(T value)
        {
            CurrentValue = value;
            OnNewValue?.Invoke(value);
        }
    }
}
