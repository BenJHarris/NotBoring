using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
    

    public SpriteRenderer fg;
    public SpriteRenderer bg;

    public Material fgDefault;
    public Material fgPlaceable;
    public Material fgNotPlaceable;

    public Material bgPlaceable;
    public Material bgNotPlaceable;

    public bool placed = false;
    public bool placeable = false;

    public Vector2 boxSize;

    private Camera cam;
    private GameMgr gm;

    private void Start()
    {
        cam = Camera.main;
        gm = FindObjectOfType<GameMgr>();
    }

    // Update is called once per frame
    void Update()
    {
        if (placed) return;

        Vector2 pos = cam.ScreenToWorldPoint((Vector2)Input.mousePosition);

        transform.position = pos;

        if (!placeable)
        {
            fg.material = fgNotPlaceable;
            bg.material = bgNotPlaceable;
        } else
        {
            fg.material = fgPlaceable;
            bg.material = bgPlaceable;
        }

        if (placeable && Input.GetMouseButtonDown(0))
        {
            placed = true;
            fg.material = fgDefault;
            bg.enabled = false;
            gm.ClearTreesInBox(transform.position, boxSize);
        }
    }

    private void FixedUpdate()
    {
        int layerMask = (1 << 8) | (1 << 10);

        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxSize, 0, layerMask);
        placeable = hits.Length == 1;
    }
}
