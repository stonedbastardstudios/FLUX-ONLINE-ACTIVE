using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
using UnityEngine;

public class TestGetDnaValues : MonoBehaviour {

    public DynamicCharacterAvatar avatar;

	// Use this for initialization
	void Start () {
        avatar = GetComponent<DynamicCharacterAvatar>();
	}
	
	// Update is called once per frame
	void Update () {
 
    }

    public void TestSetDNA() {
        Dictionary<string, DnaSetter> dna = avatar.GetDNA();

        dna["headSize"].Set(1f);
        Debug.Log(dna["headSize"].Value);
        avatar.ForceUpdate(true, false, false);
    }

    public void DisplayDna() {
        UMADnaBase[] dna = avatar.GetAllDNA();

        foreach (UMADnaBase d in dna) {
            string[] names = d.Names;
   
            for (int i = 0; i < names.Length; i++)
            {
                string Name = names[i];

                Debug.Log(Name);
            }


        }  
    }
}
