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
    public Dropdown mHairDrop;
    public Dropdown fHairDrop;
        
    #region Buttons
    public void MaleButton() {
            avatar.ChangeRace("HumanMale");
            fHairDrop.gameObject.SetActive(false);
            mHairDrop.gameObject.SetActive(true);
        }

    public void FemaleButton() {
            avatar.ChangeRace("HumanFemale");
            mHairDrop.gameObject.SetActive(false);
            fHairDrop.gameObject.SetActive(true);
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
