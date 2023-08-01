using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public string product;

    public Image[] emptyIcon;
    public Sprite fillIcon;
    public int UpgradeLimit;
    public int scoreUpgrade;
    LevelController levelController;

    public int count;
    void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        iconsUpdate();
    }

    public void OnEnable()
    {
        iconsUpdate();
    }

    public void productUpgrade()
    {
       
            //PlayerPrefs.GetInt(product);

        if (count < UpgradeLimit)
        {
            levelController.ScoreUpgrade--;
            count++;
            //PlayerPrefs.SetInt(product, count);

            emptyIcon[count - 1].overrideSprite = fillIcon;
        }
    }

    void iconsUpdate()
    {
        //PlayerPrefs.GetInt(product);

        for (int i = 0; i < count; i++)
        {
            emptyIcon[i].overrideSprite = fillIcon;
        }
    }
}
