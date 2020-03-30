using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BuildingVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public Building InitialValue;

    [System.NonSerialized]
    public Building RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize() { }
}