using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTrigger : MonoBehaviour
{

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = cam.ScreenToWorldPoint(Input.mousePosition);

        Collider2D[] hits = Physics2D.OverlapPointAll(position);

        foreach (Collider2D h in hits)
        {
            AddPrefabOnHover p = h.GetComponent<AddPrefabOnHover>();
            if (p != null)
            {
                p.Show();
            }
        }
    }
}
