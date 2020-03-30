using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public int InitialValue;
    public GameEvent updateEvent;

    private int _runtimeValue;

    public int RuntimeValue
    {
        get => _runtimeValue;
        set {
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