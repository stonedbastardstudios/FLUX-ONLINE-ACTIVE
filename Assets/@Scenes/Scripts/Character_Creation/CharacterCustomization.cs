using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace UMA.CharacterSystem
{

    public class CharacterCustomization : MonoBehaviour
    {

        public DynamicCharacterAvatar avatar;
        public GameObject headPanel;
        public GameObject bodyPanel;
        public GameObject fHairPanel;
        public Dropdown mHairDrop;
        public Dropdown fHairDrop;
        public Camera cam;

        ProfileInfo profileInfo;

        bool headPress = false;
        bool bodyPress = true;

        void Start() {
            profileInfo = GameObject.Find("ProfileInfo").GetComponent<ProfileInfo>();
        }

        public void FixedUpdate()
        {
            if (headPress && avatar.transform.childCount > 0) {
                float y = GameObject.Find("NoseBase").transform.position.y;
                cam.transform.position = new Vector3(cam.transform.position.x, y, -0.64f);
                bodyPress = false;
            }

            if (bodyPress && avatar.transform.childCount > 0)
            {
                float y = GameObject.Find("Neck").transform.position.y;
                cam.transform.position = new Vector3(cam.transform.position.x, y - 0.45f, -1.5f);
                headPress = false;
            }
        }

        #region Buttons
        public void MaleButton()
        {
            avatar.ChangeRace("HumanMale");
            fHairDrop.gameObject.SetActive(false);
            mHairDrop.gameObject.SetActive(true);
            fHairPanel.SetActive(true);
        }

        public void FemaleButton()
        {
            avatar.ChangeRace("HumanFemale");
            mHairDrop.gameObject.SetActive(false);
            fHairDrop.gameObject.SetActive(true);
            fHairPanel.SetActive(false);
        }

        public void HeadButton()
        {
            bodyPress = false;
            headPress = true;

            if (!headPanel.activeSelf)
            {
                headPanel.SetActive(true);
                bodyPanel.SetActive(false);
            }
            else return;
        }

        public void BodyButton()
        {
            headPress = false;
            bodyPress = true;

            if (!bodyPanel.activeSelf)
            {
                headPanel.SetActive(false);
                bodyPanel.SetActive(true);
            }
            else return;
        }
        
        public void Back() {
            SceneManager.LoadScene("Character_Selection");
        }

        public void Continue() {
            string dir = "C:/Users/Stonedmaster/Documents/My Games/Flux Online/Profiles/";
            string profileName = profileInfo.profileName;
            int saveSlot = profileInfo.saveSlot;
            bool exists = Directory.Exists(dir);
            if (!exists) Directory.CreateDirectory(dir);

            // Generate UMA String
            var recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
            //var recipe = avatar.GetComponent<UMATextRecipe>();
            recipe.Save(avatar.umaData.umaRecipe, avatar.context );
            string saveString = recipe.recipeString;
            Destroy(recipe);

            // Save uma recipe string to txt file
            string fileName = dir+profileName+"Slot ("+saveSlot+").txt";// Save file name change later
            StreamWriter stream = File.CreateText(fileName);
            stream.WriteLine(saveString);
            stream.Close();
            SceneManager.LoadScene("Character_Selection");
        }

        public void BackButton() {
            SceneManager.LoadScene("Character_Selection");
        }

        #endregion
    }
}
