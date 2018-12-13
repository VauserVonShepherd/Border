using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticFunctions {
    public static Vector3 SpawnInCircle(Vector3 center, float radius, int squadSize, int loopVal)
    {
        int ang = 360 / squadSize * loopVal;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
