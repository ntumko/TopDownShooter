using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GunType gunType;
    public float offset;
    public GameObject bulletPrefabe;
    public Transform shotPoint;

    private float timeBtwShots;
    private float rotZ;
    private Player player;
    public float startTimeBtwShots;
    
    public enum GunType {Default, Enemy}

    private void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        if (gunType == GunType.Default)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 difference = mousePosition - (Vector2)transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        }
        else if(gunType == GunType.Enemy)
        {
            Vector2 difference = player.transform.position - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        }
        //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0) || gunType == GunType.Enemy)
            {
                GameObject bullet = Instantiate(bulletPrefabe, shotPoint.position, transform.rotation);
                //bullet.transform.rotation = Quaternion.Euler(0, 0, 180);
                bullet.transform.Rotate(Vector3.forward * 0);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }


}
