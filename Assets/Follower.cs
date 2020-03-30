using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    private UnitMovement unitMovement;
    private GameObject player;
    public bool shouldFollow = true;
    public float waitTime = 0.25f;
    public float followRange = 3f;

    // Start is called before the first frame update
    void Start()
    {
        unitMovement = GetComponent<UnitMovement>();
        player = FindObjectOfType<PlayerMovement>().gameObject;
        StartCoroutine("UpdateTargetLocation");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < followRange)
        {
            unitMovement.StopMovement();
        } else
        {
            unitMovement.StartMovement();
        }
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
