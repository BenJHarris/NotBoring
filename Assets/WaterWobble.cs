using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWobble : MonoBehaviour
{

    private float originalY;

    private void Start()
    {
        originalY = transform.position.y; ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, originalY + Mathf.Sin(Time.time) * 0.2f);
    }
}
