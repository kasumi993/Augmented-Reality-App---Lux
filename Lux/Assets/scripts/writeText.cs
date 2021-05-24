using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writeText : MonoBehaviour
{
    public float delay;
    public float startTime=0;
    bool play=true;
    Text txt;
	string fullText;
    // fullText.text = fullText.text.Replace("B", "<color=#ffffffxx>B</color>");

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text> ();
		fullText = txt.text;
		txt.text = "";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText(){
        yield return new WaitForSeconds(startTime);
        foreach (char c in fullText) 
		{
			txt.text += c;
            if (play){
			    yield return new WaitForSeconds (this.delay);
            }
		}
    }

    public void stop(){
        play=false;
    }

}
