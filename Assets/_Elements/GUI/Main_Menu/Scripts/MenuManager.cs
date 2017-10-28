using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject settingsMenu;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseWindow() {
        settingsMenu.SetActive(false);

    }

    public void OpenWindow()
    {
        settingsMenu.SetActive(true);

    }
}
