using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opacity : MonoBehaviour
{
    public IsTracking isTracking;

    public GameObject cadre;

    void Update()
    {
        if (isTracking.isTracking == true)
        {
            cadre.SetActive(false);
        }
    }
}