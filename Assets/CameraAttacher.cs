using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAttacher : MonoBehaviour
{


    public GameObject objToFollow;
    public float strength = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 newPos = Vector2.Lerp(transform.position, objToFollow.transform.position, Time.deltaTime * strength);

        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
    }
}
