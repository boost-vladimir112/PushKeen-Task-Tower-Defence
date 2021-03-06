using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] protected float _lifeTime = 8f;
    [SerializeField] protected float _bulletSpeed = 60f;
    [SerializeField] protected int _damage = 2;

    public int Damage { get => _damage; set => _damage = value; }

    private void Update()
    {
        BulletLifeTime();
        Shot();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("EnemyTower"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("EnemyField"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
   
    protected void BulletLifeTime()
    {
        _lifeTime -= Time.deltaTime;
        if(_lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
  
    private void Shot()
    {
        transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
    }




}
