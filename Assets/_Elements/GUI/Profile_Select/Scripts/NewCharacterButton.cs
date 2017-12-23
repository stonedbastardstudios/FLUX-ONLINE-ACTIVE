using UnityEngine.SceneManagement;
using UnityEngine;

public class NewCharacterButton : MonoBehaviour {

    ProfileInfo profileInfo;

    void Start() {
        profileInfo = GameObject.Find("ProfileInfo").GetComponent<ProfileInfo>();
    }

    public void OnMouseDown() {

        string saveSlot = gameObject.name;
        saveSlot = saveSlot.Substring(saveSlot.Length - 2, 1);
        profileInfo.saveSlot = int.Parse(saveSlot);
        TextMesh textMesh = GetComponent<TextMesh>();
        Color color = textMesh.color;

        textMesh.color = new Color(color.r, color.g, color.b, 1f);
        SceneManager.LoadScene("Character_Creation");
        textMesh.color = new Color(color.r, color.g, color.b, 0.70f);
    }
}
