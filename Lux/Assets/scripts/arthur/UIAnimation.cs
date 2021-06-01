using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAnimation : MonoBehaviour
{
    Ray screenCenter;
    RaycastHit hit;

    GameObject colliderButton; //Bouton en train d'�tre vis�
    GameObject tempCollider; //Bouton pr�c�demment vis�

    private void Awake()
    {
        //Initialisation de tempCollider pour qu'il ne soit pas null au moment de le comparer avec colliderButton � la ligne 30, auquel cas le if ne s'ex�cute jamais
        tempCollider = GameObject.Find("Empty");
    }

    void Update()
    {
        screenCenter = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(screenCenter, out hit))
        {
            if (hit.collider != null)
            {
                colliderButton = hit.collider.gameObject;                   //D�tection de quel bouton est vis�
                colliderButton.GetComponent<ButtonAnim>().highlighting();   //Mise en �vidence du bouton

                if (colliderButton.name != tempCollider.name)               //Si le bouton a chang� par rapport � la pr�c�dente frame
                {
                    tempCollider.GetComponent<ButtonAnim>().setInit();      //Recul du pr�c�dent bouton vis�
                    tempCollider = colliderButton;
                }
            }
        }
        else
        {
            colliderButton.GetComponent<ButtonAnim>().setInit();            //Si aucun objet n'est vis� (sortie du bouton), recul de celui-ci
        }
    }
}