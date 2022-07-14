using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] protected float _lifeTime = 8f;

    [SerializeField] protected float _bulletSpeed = 60f;

    [SerializeField] protected int _damage = 2;

    Rigidbody2D rb;

    public int Damage { get => _damage; set => _damage = value; }

    private void Start()
    {

    }
    private void Update()
    {
        BulletLifeTime();
        Shot();
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("EnemyTower"))
        {
            other.gameObject.GetComponent<Tower>().TakeDamage(_damage);
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
  
    protected void Shot()
    {
        transform.Translate(Vector2.right * _bulletSpeed * Time.deltaTime);
    }




}
