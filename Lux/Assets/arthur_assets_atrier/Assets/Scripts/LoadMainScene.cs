using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    private GUIStyle gUIStyle;

    private void Awake()
    {
        gUIStyle = new GUIStyle();
        gUIStyle.normal.textColor = Color.white;
        gUIStyle.fontSize = 150;
        gUIStyle.alignment = TextAnchor.MiddleCenter;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(200, 2601, 1040, 220), "Retour", gUIStyle))
            SceneManager.LoadScene("Poster");
    }
}