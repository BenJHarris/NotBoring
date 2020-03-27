using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Camera cam;

    private int zoomLevel = 1;

    private int baseSize = 6;
    private int inc = 2;

    private float startSize;
    private float targetSize;

    private float startTime;

    bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        startSize = cam.orthographicSize;
        targetSize = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            zoomLevel = (zoomLevel + 1) % 3;

            if (zoomLevel == 0)
            {
                targetSize = baseSize;
            } else
            {
                targetSize = cam.orthographicSize * inc;
            }

            moving = true;
            startTime = Time.time;
            startSize = cam.orthographicSize;

        }

        if (moving)
        {
            cam.orthographicSize = Mathf.Lerp(startSize, targetSize, Time.time - startTime);
        }

        
    }
}
