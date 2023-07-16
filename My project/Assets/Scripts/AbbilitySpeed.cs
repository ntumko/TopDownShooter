using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbilitySpeed : MonoBehaviour
{
   
    public float SpeedUp;
    public float duration;
    public float Delay;
    private Enemy enemy;


    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }


    private void Start()
    {

        //InvokeRepeating("StartAbility", 5, Delay);
        StartCoroutine(StartAbility());   
    }

    IEnumerator StartAbility()
    {
        while (true)
        {
            yield return new WaitForSeconds(Delay);
            enemy.addedSpeed = SpeedUp;
            yield return new WaitForSeconds(duration);
            print(1);
            enemy.addedSpeed = 0;
        }
    }
}
