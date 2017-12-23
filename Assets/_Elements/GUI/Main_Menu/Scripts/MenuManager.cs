using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject settingsMenu;
    public GameObject loginMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseWindow() {
        settingsMenu.SetActive(false);
        loginMenu.SetActive(false);
    }

    public void LoginWindow() {
        loginMenu.SetActive(true);
    }

    public void SettingsWindow()
    {
        settingsMenu.SetActive(true);

    }
}
