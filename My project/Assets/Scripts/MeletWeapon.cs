using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeletWeapon : MonoBehaviour
{
    public float startTimeBtwAttack;
    private float timeBtwAttack;
    public int damage;
    private Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = collision.gameObject.GetComponent<Player>();

        if (player)
        {
            StartCoroutine(OnEnemyAttack());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        player = collision.gameObject.GetComponent<Player>();

        if (player)
        {
            StopCoroutine(OnEnemyAttack());
        }
    }

    public IEnumerator OnEnemyAttack()
    {
        while (true)
        {
            player.health -= damage;
            yield return new WaitForSeconds(1);
        }
        //player.health -= damage;
        //timeBtwAttack = startTimeBtwAttack;
    }

    void Update()
    {
       /* Physics2D.CircleCast(transform.position, 3);
        Physics2D.CircleCast()*/
    }
}
