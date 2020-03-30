using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{

    public IntVariable goldVariable;
    public IntVariable scoreVariable;

    public GameObject soldierPrefab;

    private GameObject player;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    public void AddGold()
    {
        goldVariable.RuntimeValue += 1000;
    }

    public void AddScore()
    {
        scoreVariable.RuntimeValue += 10000;
    }

    public void SpawnSoldier()
    {
        Instantiate(soldierPrefab, player.transform.position, Quaternion.identity);
    }
}
