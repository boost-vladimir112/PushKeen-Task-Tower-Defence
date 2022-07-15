using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    private void Update()
    {
        Shot();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerTower"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("PlayerField"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
 
    private void Shot()
    {
        transform.Translate(Vector2.left * _bulletSpeed * Time.deltaTime);
    }
}
