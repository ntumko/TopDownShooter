using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordDoor : MonoBehaviour
{
    [SerializeField]
    int password;
    public int Password => password;
    public void Disable()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
