using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static bool isRecyclable(Vector3 v)
    {
        float m = 5.0f; //margine

        Camera camera = Camera.main;
        Vector3 bottomleft = camera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f));
        Vector3 topright = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        if (v.x <= bottomleft.x - m || v.x >= topright.x + m || v.y <= bottomleft.y - m || v.y >= topright.y + m)
            return true;
        else
            return false;
    }
}
