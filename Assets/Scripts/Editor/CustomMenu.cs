using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class CustomMenu
{
    [MenuItem("Custom Menu/My Custom Method")]
    public static void SendAMessage()
    {
        Debug.Log("Inventory Reset");
    }
}
