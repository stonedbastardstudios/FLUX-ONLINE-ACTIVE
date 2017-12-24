using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine;

namespace UMA.CharacterSystem
{
    public class LCNC : MonoBehaviour {

        public DynamicCharacterAvatar[] avatars;
        public GameObject[] createButtons;

        ProfileInfo profileInfo;
        bool initialised;

        // Use this for initialization
        void Start() {
            profileInfo = GameObject.Find("ProfileInfo").GetComponent<ProfileInfo>();
            //LoadProfileSaves();
        }

        // Update is called once per frame
        void Update() {
           if (Time.timeSinceLevelLoad > 1 && !initialised) {
                LoadProfileSaves();
                initialised = true;
           }
        }

        public void LoadProfileSaves() {

            string dir = "C:/Users/Stonedmaster/Documents/My Games/Flux Online/Profiles/";
            string profileName = profileInfo.profileName;
            bool exists = Directory.Exists(dir);
            if (!exists) Directory.CreateDirectory(dir);

            foreach (DynamicCharacterAvatar avatar in avatars) {

                // Load string from text file
                string fileName = dir+profileName+avatar.name+".txt";
                int avatarSlot = int.Parse(avatar.name.Substring(avatar.name.Length - 2, 1));
                
                // Check if save file exists
                if (File.Exists(fileName) == false) {
                    if (avatarSlot == 1) {
                        avatar.gameObject.SetActive(false); // Turn off avatar if save file doesnt exist
                        createButtons[0].gameObject.SetActive(true);
                    } 

                    if (avatarSlot == 2)
                    {
                        avatar.gameObject.SetActive(false); // Turn off avatar if save file doesnt exist
                        createButtons[1].gameObject.SetActive(true);
                    } 

                    if (avatarSlot == 3)
                    {
                        avatar.gameObject.SetActive(false); // Turn off avatar if save file doesnt exist
                        createButtons[2].gameObject.SetActive(true);
                    }
                } 

                if (File.Exists(fileName) && avatarSlot == 1) {
                    createButtons[0].gameObject.SetActive(false);
                    avatar.gameObject.SetActive(true);
                    StreamReader stream = File.OpenText(fileName);
                    string saveString = stream.ReadLine();
                    stream.Close();

                    //Regenerate UMA using string
                    UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
                    recipe.recipeString = saveString;
                    avatar.LoadFromRecipe(recipe);
                    Destroy(recipe);
                }

                if (File.Exists(fileName) && avatarSlot == 2) {
                    createButtons[1].gameObject.SetActive(false);
                    avatar.gameObject.SetActive(true);
                    StreamReader stream = File.OpenText(fileName);
                    string saveString = stream.ReadLine();
                    stream.Close();

                    //Regenerate UMA using string
                    UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
                    recipe.recipeString = saveString;
                    avatar.LoadFromRecipe(recipe);
                    Destroy(recipe);
                }

                if (File.Exists(fileName) && avatarSlot == 3) {
                    createButtons[2].gameObject.SetActive(false);
                    avatar.gameObject.SetActive(true);
                    StreamReader stream = File.OpenText(fileName);
                    string saveString = stream.ReadLine();
                    stream.Close();

                    //Regenerate UMA using string
                    UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
                    recipe.recipeString = saveString;
                    avatar.LoadFromRecipe(recipe);
                    Destroy(recipe);
                }
            }
        }
    }
}