using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMaster : MonoBehaviour {

    public int loadPause = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > loadPause) {
            SceneManager.LoadScene("Title_Screen");
        }
	}
}
