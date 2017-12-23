using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UMA.CharacterSystem;
using UnityEngine;

/*
 * NOTE - The name of the UI slider gameObject in the scene must correspond with an 
 * existing dna value (The not the text object) ex.. headSize  camel casing required.
*/
public class DNASliderHandler : MonoBehaviour {

    public DynamicCharacterAvatar avatar;
    public Slider slider;
    public Dictionary<string, DnaSetter> dna = new Dictionary<string, DnaSetter>();


    private void Start() {
        avatar = GameObject.Find("PlayerMannequin").GetComponent<DynamicCharacterAvatar>();
        slider = GetComponentInChildren<Slider>();
        
    }

    private void FixedUpdate() {
        if (dna.Count <= 0) { //check if dictionary has not been populated.
            dna = avatar.GetDNA(); //Polpulates dcitionary with dna value from the avatar.
            if (dna.ContainsKey(gameObject.name)) { //check if dna contains string key for this gameObjects name.
                //sets sliders value to the dna's value with this gameObjects Name.
                slider.value = dna[gameObject.name].Value; 
            }   else return;
        }
        ValueChanged(gameObject.name, slider.value);
    }

    public void ValueChanged(string name, float value) {
        
        dna[name].Set(value); //sets dna value defined by name and value input.
        avatar.ForceUpdate(true, false, false); //updates the avatar with the dna change.
        dna = avatar.GetDNA(); //Refresh's dictionary with the new dna settings. 
        slider.value = dna[gameObject.name].Value; //sets slider to the new values
    }
}
