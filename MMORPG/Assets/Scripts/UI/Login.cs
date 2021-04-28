using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public Button login;
    public GameObject serverSelect;

    // Start is called before the first frame update
    void Start()
    {
        login.onClick.AddListener(() => {
            PlayerLogin();
        });
    }

    public void PlayerLogin()
    {
        if(string.IsNullOrEmpty(username.text) || string.IsNullOrEmpty(password.text))
        {
            //TODO: add message stating wrong password/username
            return;
        }

        //send a message to the server to login and check to see if they have an account
    }
}

