﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int ScoreUpgrade;

    public void AddScoreUpgrade(int Score)
    {
        ScoreUpgrade += Score;
    }
}
