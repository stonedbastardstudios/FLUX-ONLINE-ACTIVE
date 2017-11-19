using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
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

        bool headPress = false;
        bool bodyPress = true;

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
        #endregion
    }
}
