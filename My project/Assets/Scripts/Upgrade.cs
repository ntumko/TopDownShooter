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

    void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        iconsUpdate();
    }
    public void productUpgrade()
    {
        int count = PlayerPrefs.GetInt(product);

        if (count < UpgradeLimit)
        {
            levelController.ScoreUpgrade--;
            count++;
            PlayerPrefs.SetInt(product, count);

            emptyIcon[count - 1].overrideSprite = fillIcon;
        }
    }

    void iconsUpdate()
    {
        int count = PlayerPrefs.GetInt(product);

        for(int i = 0; i < count; i++)
        {
            emptyIcon[i].overrideSprite = fillIcon;
        }
    }
}
