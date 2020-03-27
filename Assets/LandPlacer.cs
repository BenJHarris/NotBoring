using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandPlacer : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 position = cam.ScreenToWorldPoint(Input.mousePosition);

            Collider2D[] hits = Physics2D.OverlapPointAll(position);

            foreach (Collider2D h in hits)
            {
                Sea s = h.GetComponent<Sea>();
                if (s != null)
                {
                    s.PurchaseLand();
                }
            }
        }
    }
}
