using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float health;
    public float defaultspeed;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private Animator anim;
    private SpriteRenderer sprite;

    private bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

        StatsUpdate();
    }

  
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * (speed + defaultspeed);



        if(moveInput.x == 0)
        {
            anim.SetBool("Walker", false);
        }
        else
        {
            anim.SetBool("Walker", true);
        }
        

        if (!facingRight && moveInput.x > 0)
        {
            Flip();
        }
        else if(facingRight && moveInput.x < 0)
        {
            Flip();
        }
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        sprite.flipX = facingRight;
        facingRight = !facingRight;
       
       
    }

    public void ChangeHealth(int healthValue)
    {
        health += healthValue;
    }

    public void StatsUpdate()
    {
        if (speed == 0) PlayerPrefs.SetInt("Hero Speed", 1);

        speed = PlayerPrefs.GetInt("Hero Speed");
    }
}
