using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LogReg : MonoBehaviour {

    public GameObject loginButton;
    public GameObject loadingPanel;

    ProfileInfo profileInfo;
    string username;
    string password;
    string url = "http://localhost/userlogin/clientlog.php";
    string authenticated = "false";

    Text errorlog;
    //string[] logCreds;

    void Start() {
        profileInfo = GameObject.Find("ProfileInfo").GetComponent<ProfileInfo>();
        errorlog = gameObject.transform.Find("Errors").GetComponent<Text>();
    }

    #region Example for formatting long strings from php echo
    // Handy Example for formatting long strings from php echo
    /*IEnumerator Start () {
        WWW loginData = new WWW(url);
        // Wait for url to finish downloading
        yield return loginData;
        // Create string with value of URL echo
        string loginString = loginData.text;
        logCreds = loginString.Split(';');
        Debug.Log(GetLogDataValue(logCreds[0], "Password:"));
	}

    string GetLogDataValue(string data, string index) {
        string value = data.Substring(data.IndexOf(index)+index.Length);
        if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
        return value;
    }*/
    #endregion

    // Update is called once per frame
    void Update () {
        username = gameObject.transform.Find("Username").GetComponent<InputField>().text;
        password = gameObject.transform.Find("Password").GetComponent<InputField>().text;
    }
    public void LoginButton() {
        StartCoroutine(Login());
    }

    IEnumerator Login() {
        string u = username;
        string p = password;

        if (u != "" && p != "") {
            WWWForm form = new WWWForm();
            form.AddField("username", u);
            form.AddField("password", p);

            WWW www = new WWW(url, form); // Creates WWW gameobject with URL value and defined Form info
            yield return www;
            authenticated = www.text;
            if (authenticated == "true") {
                Debug.Log("Authentication Successful");

                // Send information to PlayerInfo class
                profileInfo.profileName = u;
             
                // Clear all Variable fields
                p = "";

                LoadPanel();
            }
            else {
                errorlog.text = "Incorrect Username or Password!";
            }
        } else {
            errorlog.text = "Cannot Enter Blank Fields!";
        }
    }

    void LoadPanel() {
        loadingPanel.SetActive(true);
        
        // Load to Character selection screen
        SceneManager.LoadScene("Character_Selection"); 
    }

    public void Register() {
        Application.OpenURL("http://localhost/userlogin/register.php");
    }
}
