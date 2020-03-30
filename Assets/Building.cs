using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Building : MonoBehaviour
{
    public BuildingRuntimeList buildingList;

    // references
    public SpriteRenderer sr;

    protected int buildingId;
    protected int maxHealth;
    protected int currentHealth;

    void Start()
    {
        buildingList.RegisterBuilding(this);
    }

}
