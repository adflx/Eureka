using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class plantes : MonoBehaviour {
    public AudioSource audio;
    public GameObject MStatscreen;
    public GameObject MStatscreen2;
    bool cs;

   	void Start () {
        cs = false;        
	}

    public void OnPointerEnter (PointerEventData eventData)
    {
        audio.gameObject.SetActive(true);
        MStatscreen.SetActive(true);
        MStatscreen2.SetActive(true);
        /*if (Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.Space))
        {
            cs = !cs;

        }
        if (cs)
        {
            //AudioSource.PlayClipAtPoint(sounds, Camera.main.transform.position);
            audio.gameObject.SetActive(true);
            MStatscreen.SetActive(true);
            MStatscreen2.SetActive(true);
        }
        else if (!cs)
        {
            audio.gameObject.SetActive(false);
            MStatscreen.SetActive(false);
            MStatscreen2.SetActive(false);
        }*/
    }

	void Update () {
        

	}

    
}
