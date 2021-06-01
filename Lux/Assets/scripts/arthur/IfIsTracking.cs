using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfIsTracking : MonoBehaviour
{
    public IsTracking isTracking;

    public ActiveUI activeUI;

    public GameObject scanne;
    public GameObject credits;

    void Update()
    {
        if (isTracking.isTracking == true)
        {
            Destroy(scanne);
            Destroy(credits);
            activeUI.SetPanelActive();
        }
    }
}
