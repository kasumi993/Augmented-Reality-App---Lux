using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUI : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    public void SetPanelActive()
    {
        panel.SetActive(true);
    }
}
