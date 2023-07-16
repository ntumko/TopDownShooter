using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void OnEnable()
    {
        Time.timeScale = 1;
    }
    public void OnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
