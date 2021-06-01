using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Ray touchPosition;
    RaycastHit hit;

    private string touchedCollider;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(touchPosition, out hit))
            {
                if (hit.collider != null)
                {
                    touchedCollider = hit.collider.name;
                    SceneManager.LoadScene(touchedCollider);
                }
            }
        }
    }
}