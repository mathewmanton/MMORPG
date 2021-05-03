using UnityEngine;
using TMPro;
using UnityEngine.UI;
using PlayFab.ClientModels;
using PlayFab;

public class Login : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public Button login;
    public Button createAccount;
    public GameObject serverSelect;
    public string titleId;

    // Start is called before the first frame update
    void Start()
    {
        login.onClick.AddListener(() => {
            PlayerLogin();
        });

        createAccount.onClick.AddListener(() => {
            CreateAccount();
        });
    }

    public void PlayerLogin()
    {
        if(string.IsNullOrEmpty(username.text) || string.IsNullOrEmpty(password.text))
        {
            //TODO: add message stating wrong password/username
            return;
        }

        //Login to playfab
        var request = new LoginWithEmailAddressRequest { Email = username.text, Password = password.text };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }

    public void CreateAccount()
    {
        if (string.IsNullOrEmpty(username.text) || string.IsNullOrEmpty(password.text))
        {
            return;
        }

        //create an account on playfab
        var request = new RegisterPlayFabUserRequest { Email = username.text, Password = password.text, Username = "Chaos", DisplayName = "Chaos", TitleId = titleId };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnCreateAccountSuccess, OnCreateAccountFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Login Success");
        //Connect to server and go to the character selection screen
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.Log("Login Failure");
        //display error message
    }

    private void OnCreateAccountSuccess(RegisterPlayFabUserResult result)
    {
        Debug.Log("Create Account Success");
         //Login after creating an account
    }

    private void OnCreateAccountFailure(PlayFabError error)
    { 
        Debug.Log("Create Account Failure");
        //display errors
    }
}

