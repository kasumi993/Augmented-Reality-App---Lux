using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    // Vitesse et distance d'avancée du bouton
    private float speed;
    private float advance;

    //Position initiale et position du bouton mis en évidence
    public Vector3 positionInit;
    Vector3 positionTarget;

    void Start()
    {
        speed = 1f;
        advance = 1f;

        positionInit = transform.localPosition;
        positionTarget = positionInit + new Vector3(0f, advance, 0f);
    }

    public void highlighting()
    {
        transform.localPosition = Vector3.MoveTowards(positionInit, positionTarget, speed * Time.deltaTime);
    }

    public void setInit()
    {
        transform.localPosition = positionInit;
    }
}
