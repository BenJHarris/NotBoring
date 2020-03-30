using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWobble : MonoBehaviour
{

    private float originalY;

    private void Start()
    {
        originalY = transform.localPosition.y; ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector2(transform.localPosition.x, originalY + Mathf.Sin(Time.time) * 0.2f);
    }
}
