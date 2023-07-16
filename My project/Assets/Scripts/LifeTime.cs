using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnEnable()
    {
        Invoke("Deactivate", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
