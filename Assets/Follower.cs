using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    public UnitMovement unitMovement;
    private GameObject player;
    public bool shouldFollow = true;
    public float waitTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
        StartCoroutine("UpdateTargetLocation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator UpdateTargetLocation()
    {
        while (shouldFollow)
        {
            unitMovement.SetDestination(player.transform.position);
            yield return new WaitForSeconds(waitTime);
        }
    }


}
