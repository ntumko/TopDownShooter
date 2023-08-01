using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    //public int damage;
    public int defaultdamage;
    public LayerMask whatIsSolid;
    public Teamenum team;

    [SerializeField] bool enemyBullet;
    [SerializeField] BilletData billetData;

    private void Start()
    {
        Invoke("DestroyBullet", lifetime);

        /* if (PlayerPrefs.HasKey("Hero Gun") == false)
         {
             if (damage == 0) PlayerPrefs.SetInt("Hero Gun", 7);
         }

         StatsUpdate();*/


    }

    private void Update()
    {
        /*RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if(hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            if (hitInfo.collider.CompareTag("Player") && enemyBullet)
            {
                hitInfo.collider.GetComponent<Player>().ChangeHealth(-damage);
            }
            DestroyBullet();
        }*/
        transform.Translate(Vector2.right * speed * Time.deltaTime);
       
    }

    

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Team otherTeam = collision.gameObject.GetComponent<Team>();
        if (otherTeam == null)

        {
            
            DestroyBullet();
            return;
        }
        
        if (team == otherTeam.team)
            return;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(billetData.damage + defaultdamage);
        }
        if (collision.gameObject.CompareTag("Player") && enemyBullet)
        {
            collision.gameObject.GetComponent<Player>().ChangeHealth(-billetData.damage);
        }
        DestroyBullet();
    }
   
}
