using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDestination : MonoBehaviour
{

    public float radius = 0.5f;


    private void OnDrawGizmos()
    {
        CustomGizmos.DrawCircle(transform.position, radius);
    }
}
