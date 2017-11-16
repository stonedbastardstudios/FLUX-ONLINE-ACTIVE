using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UnityEngine.UI;
using UnityEngine;

public class ColorMenuControl : MonoBehaviour {

    public DynamicCharacterAvatar avatar;
    public GameObject skinCP;
    public GameObject facialHairCP;
    public GameObject hairCP;

    public GameObject skinBTN;
    public GameObject facialHairBTN;
    public GameObject hairBTN;

	// Use this for initialization
	void Start () {
        avatar = GameObject.Find("PlayerMannequin").GetComponent<DynamicCharacterAvatar>();
        skinBTN = skinCP.transform.parent.gameObject;
        facialHairBTN = facialHairCP.transform.parent.gameObject;
        hairBTN = hairCP.transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void colorCategoryButton() {
        if (hairBTN.GetComponent<Button>()) {
            hairCP.SetActive(true);
            Debug.Log("Hair Test");
        }
        
        if (facialHairBTN.transform.parent.name == "Facial Hair")
        {
            Debug.Log("Facial Hair Test");
        }
    }
}
