using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UnityEngine.UI;
using UnityEngine;

public class ColorMenuControl : MonoBehaviour {

    public DynamicCharacterAvatar avatar;
    public GameObject skinCP;
    public GameObject eyesCP;
    public GameObject hairCP;

    bool initialised = false;
    Button skinBTN;
    Button eyesBTN;
    Button hairBTN;

    // Use this for initialization
    void Start () {
        avatar = GameObject.Find("PlayerMannequin").GetComponent<DynamicCharacterAvatar>();
    }

    void Update() {
        if (avatar.ActiveColors.Count > 0 && !initialised) {
            skinBTN = skinCP.GetComponentInParent<Button>();
            eyesBTN = eyesCP.GetComponentInParent<Button>();
            hairBTN = hairCP.GetComponentInParent<Button>();

            ChangeColor("Skin", skinBTN.colors.normalColor.r, skinBTN.colors.normalColor.g, skinBTN.colors.normalColor.b);
            ChangeColor("Eyes", eyesBTN.colors.normalColor.r, eyesBTN.colors.normalColor.g, eyesBTN.colors.normalColor.b);
            ChangeColor("Hair", hairBTN.colors.normalColor.r, hairBTN.colors.normalColor.g, hairBTN.colors.normalColor.b);

            initialised = true;
        }
    }

    public void ChangeColor(string name, float r, float g, float b) {
        Color currentColor = new Color(r, g, b, 1f);

        avatar.SetColor(name, currentColor);
        avatar.UpdateColors(true);
    }

    public void colorHairButton() {

        if (hairCP.activeSelf == false) {
            
            eyesCP.SetActive(false);
            skinCP.SetActive(false);
            hairCP.SetActive(true);
        } else {
            hairCP.SetActive(false);
            Debug.Log("Close Window");
        }
    }

    public void colorFacialHairButton() {

        if (eyesCP.activeSelf == false)
        {
            hairCP.SetActive(false);
            skinCP.SetActive(false);
            eyesCP.SetActive(true);
        }
        else
        {
            eyesCP.SetActive(false);
            Debug.Log("Close Window");
        }
    }

    public void colorSkinButton() {
        if (skinCP.activeSelf == false) {
            hairCP.SetActive(false);
            eyesCP.SetActive(false);
            skinCP.SetActive(true);
        } else {
            skinCP.SetActive(false);
            Debug.Log("Close Window");
        }
    }
}
