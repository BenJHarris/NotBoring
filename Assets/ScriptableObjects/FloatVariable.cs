using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float InitialValue;
    public GameEvent updateEvent;

    private float _runtimeValue;

    public float RuntimeValue
    {
        get => _runtimeValue;
        set
        {
            _runtimeValue = value;
            if (updateEvent != null)
            {
                updateEvent.Raise();
            }
        }
    }

    public void OnAfterDeserialize()
    {
        _runtimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}