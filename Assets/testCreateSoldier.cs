using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCreateSoldier : MonoBehaviour
{

    public BuildingVariable building;
    public IntVariable gold;
    
    public void CreateSolider()
    {

        Building b = building.RuntimeValue;

        if (gold.RuntimeValue >= b.spawnUnitCost)
        {
            Instantiate(b.spawnUnitPrefab, building.RuntimeValue.gameObject.transform.position + new Vector3(0, -0.3f), Quaternion.identity);
            gold.RuntimeValue -= b.spawnUnitCost;
        }
    }
}
