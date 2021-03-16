using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{

    public float startTime=0;

    public void setScene(string sceneName){
        StartCoroutine(scene(sceneName));   
    }

    public IEnumerator scene(string name){
        yield return new WaitForSeconds(startTime);
        SceneManager.LoadScene(name);
    }

    public void fade(GameObject objet){
        StartCoroutine(FadeEnum(1.5f,objet));
    }

    public IEnumerator FadeEnum(float t,GameObject objet)
    {
        objet.GetComponent<CanvasGroup>().alpha = 1f;
        // i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (objet.GetComponent<CanvasGroup>().alpha > 0.0f)
        {
            objet.GetComponent<CanvasGroup>().alpha = objet.GetComponent<CanvasGroup>().alpha - (Time.deltaTime / t);
            // .color.a - (Time.deltaTime / t)
            yield return null;
        }
    }

}
