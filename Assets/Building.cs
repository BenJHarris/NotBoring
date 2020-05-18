using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Building : MonoBehaviour
{
    // references
    public SpriteRenderer sr;
    public GameObject spawnUnitPrefab;
    public int spawnUnitCost;
    public string spawnUnitName;

    protected int buildingId;
    protected int maxHealth;
    protected int currentHealth;

}
