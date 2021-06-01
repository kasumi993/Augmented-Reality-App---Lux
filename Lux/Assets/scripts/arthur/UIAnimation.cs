using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAnimation : MonoBehaviour
{
    Ray screenCenter;
    RaycastHit hit;

    GameObject colliderButton; //Bouton en train d'être visé
    GameObject tempCollider; //Bouton précédemment visé

    private void Awake()
    {
        //Initialisation de tempCollider pour qu'il ne soit pas null au moment de le comparer avec colliderButton à la ligne 30, auquel cas le if ne s'exécute jamais
        tempCollider = GameObject.Find("Empty");
    }

    void Update()
    {
        screenCenter = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(screenCenter, out hit))
        {
            if (hit.collider != null)
            {
                colliderButton = hit.collider.gameObject;                   //Détection de quel bouton est visé
                colliderButton.GetComponent<ButtonAnim>().highlighting();   //Mise en évidence du bouton

                if (colliderButton.name != tempCollider.name)               //Si le bouton a changé par rapport à la précédente frame
                {
                    tempCollider.GetComponent<ButtonAnim>().setInit();      //Recul du précédent bouton visé
                    tempCollider = colliderButton;
                }
            }
        }
        else
        {
            colliderButton.GetComponent<ButtonAnim>().setInit();            //Si aucun objet n'est visé (sortie du bouton), recul de celui-ci
        }
    }
}