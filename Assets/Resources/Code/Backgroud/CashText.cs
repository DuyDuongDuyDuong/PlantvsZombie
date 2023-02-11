using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CashText : MonoBehaviour
{

    public GUIStyle style;
    public float xPos = 80f, yPos = 23f;
    
    
    private void OnGUI()
    {
        GUI.Label(new Rect(xPos, yPos, 50, 100), GameManager.Cash.ToString(),style);
        GUI.matrix = Matrix4x4.TRS(Vector3.zero, quaternion.identity,
            new Vector3(Screen.width / 1220.0f, Screen.width / 881.0f, 1.0f));

    }
}
