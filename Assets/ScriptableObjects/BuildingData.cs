using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BuildingData", menuName = "Building Data", order = 51)]
public class BuildingData : ScriptableObject
{
    [SerializeField]
    private string buildingName;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    private Vector2 floorSize;
    [SerializeField]
    private Vector2 spriteOffset;
    [SerializeField]
    private GameObject buildingPrefab;

    public string BuildingName
    {
        get
        {
            return buildingName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Sprite
    {
        get
        {
            return sprite;
        }
    }

    public Vector2 FloorSize
    {
        get
        {
            return floorSize;
        }
    }

    public Vector2 SpriteOffset
    {
        get
        {
            return spriteOffset;
        }
    }

    public GameObject BuildingPrefab
    {
        get
        {
            return buildingPrefab;
        }
    }
}
