using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Dialogue : MonoBehaviour
{
    public static void Play()
    {

        bool playOutput = EditorUtility.DisplayDialog("Play", "Are you sure you want to enter play mode?", "Yes", "No");
        if (playOutput)
            EditorApplication.EnterPlaymode();
        else
            EditorUtility.DisplayDialog("Cancelled", "You cancelled the play mode", "OK");

    }
}
