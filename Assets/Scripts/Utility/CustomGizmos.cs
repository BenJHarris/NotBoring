using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomGizmos {

    public static void DrawCircle(Vector3 position, float radius, int points = 11)
    {
        Vector3[] positions = new Vector3[points];
        for (int i = 0; i < points; i++)
        {
            float angle = 2 * Mathf.PI / points * i;

            positions[i] = position + new Vector3(radius * Mathf.Sin(angle), radius * Mathf.Cos(angle), 0);
        }

        for (int i = 0; i < points - 1; i++)
        {
            Gizmos.DrawLine(positions[i], positions[i + 1]);
        }
        Gizmos.DrawLine(positions[points - 1], positions[0]);
    }
}
