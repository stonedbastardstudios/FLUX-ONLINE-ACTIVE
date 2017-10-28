using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

    public GameObject settingsWindows;
    public GameObject[] windows;
	
    
    // Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //Settings Navigation Buttons--------------------------------------------------------------------------------
    public void GameButton() {
        if (!windows[0].activeSelf) {
            windows[0].SetActive(true);
            windows[1].SetActive(false);
            windows[2].SetActive(false);
            windows[3].SetActive(false);
        }
    }

    public void VideoButton() {
        if (!windows[1].activeSelf)
        {
            windows[1].SetActive(true);
            windows[0].SetActive(false);
            windows[2].SetActive(false);
            windows[3].SetActive(false);
        }
    }

    public void AudioButton() {
        if (!windows[2].activeSelf)
        {
            windows[2].SetActive(true);
            windows[1].SetActive(false);
            windows[0].SetActive(false);
            windows[3].SetActive(false);
        }
    }

    public void KeyBindButton() {
        if (!windows[3].activeSelf)
        {
            windows[3].SetActive(true);
            windows[1].SetActive(false);
            windows[2].SetActive(false);
            windows[0].SetActive(false);
        }
    }

}
