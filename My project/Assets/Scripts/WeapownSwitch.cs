using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeapownSwitch : MonoBehaviour
{
    public GameObject[] weapons;
    public List<GameObject> unlockedWeapons;
    public Image weaponIcon;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SwitchWeapon();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Weapon"))
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if(other.name == weapons[i].name)
                {
                    unlockedWeapons.Add(weapons[i]);
                }
            }
            SwitchWeapon();
            Destroy(other.gameObject);
        }
    }

    public void SwitchWeapon()
    {
        for (int i = 0; i < unlockedWeapons.Count; i++)
        {
            if(unlockedWeapons[i].activeInHierarchy)
            {
                unlockedWeapons[i].SetActive(false);
                if(i != 0)
                {
                    unlockedWeapons[i - 1].SetActive(true);
                    weaponIcon.sprite = unlockedWeapons[i - 1].GetComponent<SpriteRenderer>().sprite;
                }
                else
                {
                    unlockedWeapons[unlockedWeapons.Count - 1].SetActive(true);
                    weaponIcon.sprite = unlockedWeapons[unlockedWeapons.Count - 1].GetComponent<SpriteRenderer>().sprite;
                }
                weaponIcon.SetNativeSize();
                break;
            }
        }
    }
}
