using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCreateSoldier : MonoBehaviour
{

    public BuildingVariable building;
    public IntVariable gold;
    public GameObject soldierPrefab;
    
    public void CreateSolider()
    {
        if (gold.RuntimeValue >= 100)
        {
            Instantiate(soldierPrefab, building.RuntimeValue.gameObject.transform.position, Quaternion.identity);
            gold.RuntimeValue -= 100;
        }
    }
}
