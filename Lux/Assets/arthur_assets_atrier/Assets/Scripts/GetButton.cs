using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetButton : MonoBehaviour
{
    Ray touchPosition;
    RaycastHit hit;

    private string photonsUrl;
    private string cagePhotonsUrl;

    private void Start()
    {
        photonsUrl = "https://fr.wikipedia.org/wiki/Photon";
        cagePhotonsUrl = "https://inl.cnrs.fr/cage-a-photons-spherique-a-base-dinp/";
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
                    switch(hit.collider.gameObject.name)
                    {
                        case "Photons":
                            Application.OpenURL(photonsUrl);
                            break;

                        case "CagePhotons":
                            Application.OpenURL(cagePhotonsUrl);
                            break;

                        case "SalleBlanche":
                            SceneManager.LoadScene("SalleBlanche");
                            break;

                        case "Fabrication":
                            SceneManager.LoadScene("Fabrication");
                            break;
                    }
                }
            }
        }
    }
}