using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollower : MonoBehaviour
{

    private UnitMovement unitMovement;
    public bool shouldFollow = true;
    public float waitTime = 0.25f;
    public float followRange = 1f;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        unitMovement = GetComponent<UnitMovement>();
        StartCoroutine("UpdateTargetLocation");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Input.mousePosition;
        mousepos.z = 0;
        pos = Camera.main.ScreenToWorldPoint(mousepos);




        if (Vector2.Distance(pos, transform.position) < followRange)
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
            unitMovement.SetDestination(pos);
            yield return new WaitForSeconds(waitTime);
        }
    }


}
