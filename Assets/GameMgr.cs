using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public void ClearTreesInBox(Vector3 position, Vector2 boxSize)
    {
        int layerMask = 1 << 9;
        Collider2D[] res = Physics2D.OverlapBoxAll(position, boxSize, 0, layerMask);

        foreach (Collider2D c in res)
        {
            Destroy(c.gameObject);
        }
    }
}
