using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject boss;
    public GameObject WinPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (Time.timeScale == 0) return;
        if (boss != null) return;

        WinPanel.SetActive(true);
        Time.timeScale = 0;


    }
}
