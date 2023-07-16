using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorInteract : MonoBehaviour
{
    bool IsDoorInteract;
    public GameObject PanelBreaking;
    PasswordDoor passwordDoor;

    private void Update()
    {
        if (IsDoorInteract == false) return;
        if (Input.GetKeyDown(KeyCode.E) == false) return;
        PanelBreaking.SetActive(true);
        PanelBreaking.GetComponentInChildren<ValidatePassword>().passwordDoor = passwordDoor;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        passwordDoor = collision.gameObject.GetComponent<PasswordDoor>();
        
        print(1);
        if(passwordDoor)
        IsDoorInteract = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        passwordDoor = collision.gameObject.GetComponent<PasswordDoor>();

        print(2);
        if (passwordDoor)
        {
            IsDoorInteract = false;
            PanelBreaking.SetActive(false);
        }
    }
}
