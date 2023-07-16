using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUpgrade : MonoBehaviour
{
    LevelController levelController;
    public GameObject panel;

    private void Start()
    {
        levelController = FindObjectOfType<LevelController>();

    }

    private void Update()
    {
        if (levelController.ScoreUpgrade > 0)
            panel.SetActive(true);
        else
            panel.SetActive(false);
    }
}
