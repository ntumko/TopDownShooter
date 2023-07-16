﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public int health;
    public float speed;
    public float addedSpeed;
    public int damage;
    private float stopTime;
    public float startStopTime;
    public float normalSpeed;
    private Player player;
    public LevelController levelController;

    [SerializeField]
    int Reward;
    

   

    private void Start()
    {
        player = FindObjectOfType<Player>();
        normalSpeed = speed;
        levelController = player.GetComponent<LevelController>();
    }

    private void Update()
    {
        if(stopTime <= 0)
        {
            speed = normalSpeed + addedSpeed;
        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }

        if(health <= 0)
        {
            levelController.AddScoreUpgrade(Reward);
            Destroy(gameObject);
        }

        if(player.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        stopTime = startStopTime;
        health -= damage;
    }
    
    public void OnEnemyAttack()
    {
        player.health -= damage;
        timeBtwAttack = startTimeBtwAttack;
    }
}
