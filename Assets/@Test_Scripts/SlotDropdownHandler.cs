using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
using UnityEngine.UI;
using UnityEngine;

public class SlotDropdownHandler : MonoBehaviour {

    public DynamicCharacterAvatar avatar;
    public Dropdown drp;

	// Use this for initialization
	void Start () {
        avatar = GameObject.Find("PlayerMannequin").GetComponent<DynamicCharacterAvatar>();
        drp = GetComponent<Dropdown>();
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    #region Eybrow Change Method 

    public void EyebrowChange() {
        // Get the available UMATextRecipes for this slot.
        List<UMATextRecipe> slotRecipes = avatar.AvailableRecipes["Eyebrows"];

        /*foreach (UMATextRecipe utr in slotRecipes)
        {
            Debug.Log(utr.name);
        }*/

        if (drp.value == 0)
        {
            avatar.ClearSlot("Eyebrows");
            avatar.BuildCharacter();
            avatar.ForceUpdate(true, true, true);
        }

        if (drp.value == 1)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBrow01")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 2)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBrow02")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 3)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBrowHR")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

    }

    #endregion

    #region Facial Hair Change Method

    public void FacialHairChange() {
        // Get the available UMATextRecipes for this slot.
        List<UMATextRecipe> slotRecipes = avatar.AvailableRecipes["Beard"];

        /*foreach (UMATextRecipe utr in slotRecipes)
        {
            Debug.Log(utr.name);
        }*/

        if (drp.value == 0)
        {
            avatar.ClearSlot("Beard");
            avatar.BuildCharacter();
            avatar.ForceUpdate(true, true, true);
        }

        if (drp.value == 1)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBeard1")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 2)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBeard2")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 3)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleBeard3")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }
    }

    #endregion

    #region Male Hair Change Method

    public void MaleHairChange() {
        // Get the available UMATextRecipes for this slot.
        List<UMATextRecipe> slotRecipes = avatar.AvailableRecipes["Hair"];
        
        /*foreach (UMATextRecipe utr in slotRecipes) {
            Debug.Log(utr.name);
        }*/

        if (drp.value == 0)
        {
            avatar.ClearSlot("Hair");
            avatar.BuildCharacter();
            avatar.ForceUpdate(true, true, true);
        }

        if (drp.value == 1)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleShortHair_Recipe") {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }   
        }

        if (drp.value == 2)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MilCut")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 3)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleHair1")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 4)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleHair2")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 5)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "MaleHair3")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 6)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "ShavedHead")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }
    }
    #endregion

    #region Female Hair Change Method

    public void FemaleHairChange() {
        // Get the available UMATextRecipes for this slot.
        List<UMATextRecipe> slotRecipes = avatar.AvailableRecipes["Hair"];

        /*foreach (UMATextRecipe utr in slotRecipes)
        {
            Debug.Log(utr.name);
        }*/

        if (drp.value == 0)
        {
            avatar.ClearSlot("Hair");
            avatar.BuildCharacter();
            avatar.ForceUpdate(true, true, true);
        }

        if (drp.value == 1)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "FemalePonyTail_Recipe")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 2)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "FemaleHair1")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 3)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "FemaleHair2")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 4)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "FemaleHair3")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }

        if (drp.value == 5)
        {
            foreach (UMATextRecipe utr in slotRecipes)
            {
                if (utr.name == "FemaleLongHair_Recipe")
                {
                    avatar.SetSlot(utr);
                    avatar.BuildCharacter();
                    avatar.ForceUpdate(true, true, true);
                    Debug.Log(utr.name);
                }
            }
        }
    }
    #endregion
}
