using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Building List", menuName = "Building List", order = 54)]
public class BuildingRuntimeList : ScriptableObject
{
    private List<Building> buildingList;

    public int RegisterBuilding(Building building)
    {
        buildingList.Add(building);
        return buildingList.Count - 1;
    }

    public Building getBuildingById(int id)
    {
        return buildingList[id];
    }
}
