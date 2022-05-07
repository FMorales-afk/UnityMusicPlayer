using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccountsManager : MonoBehaviour
{
    string readUsername = "";
    string readPassword = "";

    public void ReadUsername(string username)
    {
        readUsername = username;
    }

    public void ReadPassword(string password)
    {
        readPassword = password;
    }

    public void LinkButton()
    {
        if (readUsername == "") { Debug.Log("Username is empty!"); };
        if (readPassword == "") { Debug.Log("Password is empty!"); };
    }
}
