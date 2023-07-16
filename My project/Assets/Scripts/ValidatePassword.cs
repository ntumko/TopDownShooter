using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidatePassword : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    [SerializeField]
    InputField inputField;

    [SerializeField]
    GameObject txt;

    public PasswordDoor passwordDoor;
    public void validate() 
    {
        if (inputField.text == passwordDoor.Password.ToString())
        {
            passwordDoor.Disable();
            panel.SetActive(false);
        }
        else
            txt.SetActive(true);
    }
}
