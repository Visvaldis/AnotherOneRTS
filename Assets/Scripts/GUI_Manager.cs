using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Manager : MonoBehaviour {

    private void OnGUI()
    {
        Utils.DrawScreenRect(new Rect(50, 50, 200, 200), Color.green);
    }
}
