using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {

    static Texture2D whiteTexture;
    public static Texture2D WhiteTexture
    {
        get
        {
            if(whiteTexture == null)//create 1x1 white texture
            {
                whiteTexture = new Texture2D(1, 1);
                whiteTexture.SetPixel(0, 0, Color.white);
                whiteTexture.Apply();//applies all SetPixel(...) changes
            }

            return whiteTexture;
        }
    }

    public static void DrawScreenRect(Rect rect, Color color)
    {
        GUI.color = color;
        GUI.DrawTexture(rect, WhiteTexture);
        GUI.color = Color.white;
    }
}
