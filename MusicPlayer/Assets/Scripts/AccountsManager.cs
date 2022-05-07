using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Author: Hadriel Saldua
/// </summary>
public class AccountsManager : MonoBehaviour
{
    // variables to hold the read username and password
    string readUsername = "";
    string readPassword = "";

    // Function to call after ending edit on username field
    public void ReadUsername(string username)
    {
        readUsername = username; // read in the username
    }

    // Function to call after ending edit on password field
    public void ReadPassword(string password)
    {
        readPassword = password; // read in the username
    }

    // Function to call when clicking the Link Button
    public void LinkButton()
    {
        // if the fields are empty send out an error
        if (readUsername == "") { Debug.Log("Username is empty!"); };
        if (readPassword == "") { Debug.Log("Password is empty!"); };
    }
}
