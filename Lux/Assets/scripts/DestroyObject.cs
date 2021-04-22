using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public void destroyCall(GameObject objet){
        Destroy(objet);
    }
}
