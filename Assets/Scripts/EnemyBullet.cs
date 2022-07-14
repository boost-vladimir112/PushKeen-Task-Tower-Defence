using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerTower"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
        }
    }

}
