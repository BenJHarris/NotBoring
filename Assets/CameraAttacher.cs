using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAttacher : MonoBehaviour
{


    public GameObject objToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = Vector2.Lerp(transform.position, objToFollow.transform.position, Time.deltaTime);

        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
    }
}
