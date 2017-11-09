using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
using UnityEngine.UI;
using UnityEngine;

namespace UMA.CharacterSystem {

public class CharacterCustomization : MonoBehaviour {

    public DynamicCharacterAvatar avatar;
    public GameObject headPanel;
    public GameObject bodyPanel;
    public GameObject hsc; //head settings scroll view content panel
    public GameObject bsc;
    public GameObject dnaSettingPrefab;
         
    // Use this for initialization
    void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
       
	}


    #region Buttons
    public void MaleButton() {
        avatar.ChangeRace("HumanMale");
    }

    public void FemaleButton() {
        avatar.ChangeRace("HumanFemale");
    }

    public void HeadButton() {
        if (!headPanel.activeSelf) {
            headPanel.SetActive(true);
            bodyPanel.SetActive(false);
        }
        else return;
    }
         
    public void BodyButton()
    {
        if (!bodyPanel.activeSelf)
        {
            headPanel.SetActive(false);
            bodyPanel.SetActive(true);
        }
        else return;
    }
    #endregion
    
    
    
    }
}
