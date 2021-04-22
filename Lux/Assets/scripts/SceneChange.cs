using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{

    public float startTime=0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(StaticClass.LastSceneInformation);
        }
    }

    public void setScene(string sceneName){
        StaticClass.LastSceneInformation = SceneManager.GetActiveScene().name;
        StartCoroutine(scene(sceneName));   
    }

    public static class StaticClass
    {
        public static string LastSceneInformation { get; set; }
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
