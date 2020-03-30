using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Land Map", menuName = "Land Map", order = 53)]
public class LandMap : ScriptableObject
{

    [SerializeField]
    private int size;

    [SerializeField]
    private int[] map;


    public int[] Map
    {
        get
        {
            return map;
        }
    }

    public int Size
    {
        get
        {
            return size;
        }
    }

    public void OnValidate()
    {
        if (map.Length != size * size)
        {
            map = new int[size * size];
        }
    }

}
